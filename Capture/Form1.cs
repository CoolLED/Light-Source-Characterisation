using Microsoft.Identity.Client;
using NetOceanDirect;
using System.Configuration;
using System.Threading;

namespace Capture
{
    public partial class Form1 : Form
    {
        Ops_Database db = new();
        cSpectrometer spectrometer = new();

        mSpectrometerSettings settings = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
        }

        private void loadComboBoxes()
        {
            comboBoxMicroscopeManufacturer.Items.Clear();
            comboBoxMicroscopeModel.Items.Clear();
            comboBoxMicroscopeArm.Items.Clear();
            comboBoxMicroscopeOptic.Items.Clear();
            comboBoxLightsourceManufacturer.Items.Clear();
            comboBoxLightsourceModel.Items.Clear();
            comboBoxAttachmentMethod.Items.Clear();
            comboBoxLightsourceWavelength.Items.Clear();

            List<DB_Hardware> microscopeManufacturer = db.readHardwareTable("microscope_Manufacturer");
            List<DB_Hardware> microscopeModel = db.readHardwareTable("microscope_Model");
            List<DB_Hardware> microscopeArm = db.readHardwareTable("microscope_Arm");
            List<DB_Hardware> microscopeOptic = db.readHardwareTable("microscope_Optic");
            List<DB_Hardware> lightsourceManufacturer = db.readHardwareTable("lightsource_Manufacturer");
            List<DB_Hardware> lightsourceModel = db.readHardwareTable("lightsource_Model");
            List<DB_Hardware> lightsourceWavelength = db.readHardwareTable("lightsource_Wavelength");
            List<DB_Hardware> attachmentMethod = db.readHardwareTable("attachment_Method");

            foreach (DB_Hardware manufacturer in microscopeManufacturer)
            {
                comboBoxMicroscopeManufacturer.Items.Add(manufacturer.name);
            }
            foreach (DB_Hardware model in microscopeModel)
            {
                comboBoxMicroscopeModel.Items.Add(model.name);
            }
            foreach (DB_Hardware arm in microscopeArm)
            {
                comboBoxMicroscopeArm.Items.Add(arm.name);
            }
            foreach (DB_Hardware optic in microscopeOptic)
            {
                comboBoxMicroscopeOptic.Items.Add(optic.name);
            }
            foreach (DB_Hardware manufacturer in lightsourceManufacturer)
            {
                comboBoxLightsourceManufacturer.Items.Add(manufacturer.name);
            }
            foreach (DB_Hardware model in lightsourceModel)
            {
                comboBoxLightsourceModel.Items.Add(model.name);
            }
            foreach (DB_Hardware wavelength in lightsourceWavelength)
            {
                comboBoxLightsourceWavelength.Items.Add(wavelength.name);
            }
            foreach (DB_Hardware method in attachmentMethod)
            {
                comboBoxAttachmentMethod.Items.Add(method.name);
            }
        }

        private void addHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHardware formHardware = new();
            List<Model_Table_Name> tables = db.readTableNames();

            formHardware.addTables(tables);

            if (formHardware.ShowDialog() == DialogResult.OK)
            {
                DB_Hardware addHardware = formHardware.hardware;
                Model_Table_Name tableName = formHardware.tableName;
                db.addToCatalogue(tableName, addHardware);

                loadComboBoxes();

                MessageBox.Show("Hardware successfully added to the database.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSetupSpectrometer_Click(object sender, EventArgs e)
        {
            FormSpectrometer formSpectrometer = new();

            if (formSpectrometer.ShowDialog(this) == DialogResult.OK)
            {
                settings = formSpectrometer.spectrometerSettings;

                var error = spectrometer.Initialise(ConfigurationManager.AppSettings["PathCalFile"], settings);

                if(error == cSpectrometer.ErrorMessage.None)
                {
                    buttonCapture.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Spectrometer initialisation failed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            int microscopeManufacturerID = db.readRecordID("microscope_Manufacturer", comboBoxMicroscopeManufacturer.SelectedItem.ToString());
            int microscopeModelID = db.readRecordID("microscope_Model", comboBoxMicroscopeModel.SelectedItem.ToString());
            int microscopeArmID = db.readRecordID("microscope_Arm", comboBoxMicroscopeArm.SelectedItem.ToString());
            int microscopeOpticID = db.readRecordID("microscope_Optic", comboBoxMicroscopeOptic.SelectedItem.ToString());
            int lightsourceManufacturerID = db.readRecordID("lightsource_Manufacturer", comboBoxLightsourceManufacturer.SelectedItem.ToString());
            int lightsourceModelID = db.readRecordID("lightsource_Model", comboBoxLightsourceModel.SelectedItem.ToString());
            int lightsourceWavelengthID = db.readRecordID("lightsource_Wavelength", comboBoxLightsourceWavelength.SelectedItem.ToString());
            int attachmentMethodID = db.readRecordID("attachment_Method", comboBoxAttachmentMethod.SelectedItem.ToString());

            buttonCapture.Enabled = false;

            DialogResult result;

            result = MessageBox.Show("Please turn off the light source.", "Process information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                spectrometer.DarkScan();
            }

            result = MessageBox.Show("Please turn on the light source.", "Process information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Thread.Sleep(500);
                spectrometer.LightScan();
            }

            double collectionArea = Convert.ToDouble(ConfigurationManager.AppSettings.Get("Collection Area"));
            spectrometer.ProcessSpectrum(collectionArea, settings.IntegrationTime);

            result = MessageBox.Show("Would you like to save the data?", "Query?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime timestamp = DateTime.Now;
                string tableName = "catalogue";
                string tSFormatted = String.Format("{0:yyyy-MM-dd_HH-mm-ss}", timestamp);
                string fileName = String.Format("{0}__{1}__{2}__{3}__{4}__{5}__{6}__{7}__{8}.csv",
                    comboBoxLightsourceManufacturer.SelectedItem, comboBoxLightsourceModel.SelectedItem,
                    comboBoxLightsourceWavelength.SelectedItem, comboBoxMicroscopeManufacturer.SelectedItem, 
                    comboBoxMicroscopeModel.SelectedItem, comboBoxMicroscopeArm.SelectedItem, 
                    comboBoxMicroscopeOptic.SelectedItem, comboBoxAttachmentMethod.SelectedItem, tSFormatted);
                string filePath = ConfigurationManager.AppSettings.Get("PathData") + "\\" + fileName;

                // Save csv in DATA
                if (writeCSV(timestamp, filePath, tableName) == true)
                {
                    // Save csv in BACKUP
                    string backupFilePath = ConfigurationManager.AppSettings.Get("PathBackup") + "\\" + fileName;
                    if (writeCSV(timestamp, backupFilePath, tableName) == true)
                    {
                        // Write to db
                        db.writeCharacterisationData(timestamp, filePath, backupFilePath, microscopeManufacturerID, microscopeModelID, microscopeArmID,
                            microscopeOpticID, lightsourceManufacturerID, lightsourceModelID, lightsourceWavelengthID, attachmentMethodID);
                    }
                }
                else
                {
                    MessageBox.Show("Data not saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Data not saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool writeCSV(DateTime ts, string filePath, string tableName)
        {
            bool flag = false;

            // Setup CSV
            string spectrometerSerialNo = ConfigurationManager.AppSettings.Get("SpectrometerSerialNo");
            string calibrationFile = ConfigurationManager.AppSettings.Get("PathCalFile");
            var csvFile = new FileInfo(filePath);
            StreamWriter sw = csvFile.CreateText();

            // CSV headers
            // TODO : Add light source and microcsope headers
            sw.WriteLine(String.Format("Date of characterisation:,{0}", ts));
            sw.WriteLine(String.Format("Microscope Manufacturer:,{0}", comboBoxMicroscopeManufacturer.SelectedItem));
            sw.WriteLine(String.Format("Microscope Model:,{0}", comboBoxMicroscopeModel.SelectedItem));
            sw.WriteLine(String.Format("Microscope Arm:,{0}", comboBoxMicroscopeArm.SelectedItem));
            sw.WriteLine(String.Format("Microscope Optic:,{0}", comboBoxMicroscopeOptic.SelectedItem));
            sw.WriteLine(String.Format("Lightsource Manufacturer:,{0}", comboBoxLightsourceManufacturer.SelectedItem));
            sw.WriteLine(String.Format("Lightsource Model:,{0}", comboBoxLightsourceModel.SelectedItem));
            sw.WriteLine(String.Format("Lightsource Wavelength,{0}", comboBoxLightsourceWavelength.SelectedItem));
            sw.WriteLine(String.Format("Attachment Method,{0}", comboBoxAttachmentMethod.SelectedItem));
            sw.WriteLine(String.Format("Spectrometer Serial Number:,{0}", spectrometerSerialNo));
            sw.WriteLine(String.Format("Spectrometer Calibration File:,{0}", calibrationFile));
            sw.WriteLine();
            sw.WriteLine("Wavelengths,Absolute Spectral Irradiance (uW/cm^2/nm),Intensity Counts,Dark Scan,Calibration File");

            int i = 0;
            for (i = 0; i < spectrometer.spectrometerCalibrationData.Length; i++)
            {
                // Write wavelength, absolute spectral irradiance, intensity count, dark scan and calibration data
                string wavelength = String.Format("{0},", spectrometer.spectrometerWavelengths[i]);
                string asi = String.Format("{0},", spectrometer.absoluteSpectralIrradianceData[i]);
                string intensityCount = String.Format("{0},", spectrometer.lightScanData[i]);
                string darkScan = String.Format("{0},", spectrometer.darkScanData[i]);
                string calibration = String.Format("{0}", spectrometer.spectrometerCalibrationData[i]);

                sw.WriteLine(wavelength + asi + intensityCount + darkScan + calibration);
            }

            sw.Close();

            flag = true;

            return flag;
        }
    }
}