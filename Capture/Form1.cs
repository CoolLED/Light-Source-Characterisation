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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Model_Catalogue> lightSources = db.readCatalogue();
            List<Model_Table_Name> tables = db.readTableNames();

            listBox1.Items.Clear();
            buttonSetupSpectrometer.Enabled = false;

            foreach (Model_Catalogue lightSource in lightSources)
            {
                String TableName = lightSource.lightSourceManufacturer.ToUpper() + "__" + lightSource.lightSourceName.ToUpper() +
                    "__" + lightSource.microscope.ToUpper() + "__" + lightSource.microscopeObjective.ToUpper();
                TableName = TableName.Replace(' ', '_');

                var searchResult = tables.Find(tables => tables.TABLE_NAME == TableName);

                if (searchResult == null)
                {
                    var mBoxReply = MessageBox.Show("Do you want to create a database table: " + TableName, "Warning", MessageBoxButtons.YesNo);

                    if (mBoxReply == DialogResult.Yes)
                    {
                        db.creatTable(TableName);
                        listBox1.Items.Add(string.Format("{0} {1} - {2} {3}", lightSource.lightSourceManufacturer, lightSource.lightSourceName,
                            lightSource.microscope, lightSource.microscopeObjective));
                    }
                    else
                    {
                        /* Take no action */
                    }
                }
                else
                {
                    listBox1.Items.Add(string.Format("{0} {1} - {2} {3}", lightSource.lightSourceManufacturer, lightSource.lightSourceName,
                        lightSource.microscope, lightSource.microscopeObjective));
                }
            }

            //String test  = (ConfigurationManager.AppSettings["PathData"] + "\\test.csv");

        }

        private void addHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHardware formHardware = new();

            if (formHardware.ShowDialog() == DialogResult.OK)
            {
                // push to dbo.catalogue
                // db.create table
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSetupSpectrometer.Enabled = (listBox1.SelectedIndex > -1) ? true : false;
        }

        private void buttonSetupSpectrometer_Click(object sender, EventArgs e)
        {
            FormSpectrometer formSpectrometer = new();

            if (formSpectrometer.ShowDialog(this) == DialogResult.OK)
            {
                mSpectrometerSettings settings = formSpectrometer.spectrometerSettings;


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
            spectrometer.ProcessSpectrum(collectionArea);

            result = MessageBox.Show("Would you like to save the data?", "Query?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime timestamp = DateTime.Now;
                string filePath = ConfigurationManager.AppSettings.Get("PathData");

                // Save csv in DATA
                if (writeCSV(timestamp, filePath) == true)
                {
                    // Save csv in BACKUP
                    filePath = ConfigurationManager.AppSettings.Get("PathBackup");
                    if (writeCSV(timestamp, filePath) == true)
                    {
                        // Write to db
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

        private bool writeCSV(DateTime ts, string filePath)
        {
            bool flag = false;

            // Setup CSV
            string spectrometerSerialNo = ConfigurationManager.AppSettings.Get("SpectrometerSerialNo");
            string calibrationFile = ConfigurationManager.AppSettings.Get("PathCalFile");
            string tSFormatted = String.Format("{0:yyyy-MM-dd_HH-mm-ss}", ts);
            string fileName = String.Format("{0}.csv", tSFormatted); // TODO : Update file name with light source and microscope
            string path = filePath + "\\" + fileName;
            var csvFile = new FileInfo(path);
            StreamWriter sw = csvFile.CreateText();

            // CSV headers
            // TODO : Add light source and microcsope headers
            sw.WriteLine(String.Format("Date of characterisation:,{0}", ts));
            sw.WriteLine(String.Format("Spectrometer Serial Number:,{0}", spectrometerSerialNo));
            sw.WriteLine(String.Format("Spectrometer Calibration File:,{0}", calibrationFile));
            sw.WriteLine();
            sw.WriteLine("Wavelengths,Absolute Spectral Irradiance (uW/cm^2/nm),Intensity Counts,Dark Scan,Calibration File");

            for (int i = 0; i < spectrometer.absoluteSpectralIrradianceData.Length; i++)
            {
                // Write wavelength, absolute spectral irradiance, intensity count, dark scan and calibration data
                string wavelength = String.Format("{0},", spectrometer.spectrometerWavelengths[i].ToString());
                string asi = String.Format("{0},", spectrometer.absoluteSpectralIrradianceData[i].ToString()); // TODO : NaN
                string intensityCount = String.Format("{0},", spectrometer.lightScanData[i].ToString());
                string darkScan = String.Format("{0},", spectrometer.darkScanData[i].ToString());
                string calibration = String.Format("{0}", spectrometer.spectrometerCalibrationData[i].ToString()); // TODO : NaN

                sw.WriteLine(wavelength + asi + intensityCount + darkScan + calibration);
            }
            flag = true;

            return flag;
        }
    }
}