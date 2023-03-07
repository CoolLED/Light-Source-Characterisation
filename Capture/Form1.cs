using Microsoft.Identity.Client;
using NetOceanDirect;
using System.Configuration;

namespace Capture
{
    public partial class Form1 : Form
    {
        Ops_Database db = new();
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
                String TableName = lightSource.lightSourceManufacturer.ToUpper() + "__" + lightSource.lightSourceName.ToUpper();
                TableName = TableName.Replace(' ', '_');

                var searchResult = tables.Find(tables => tables.TABLE_NAME == TableName);

                if (searchResult == null)
                {
                    var mBoxReply = MessageBox.Show("Do you want to create a database table: " + TableName, "Warning", MessageBoxButtons.YesNo);

                    if (mBoxReply == DialogResult.Yes)
                    {
                        db.creatTable(TableName);
                        listBox1.Items.Add(string.Format("{0} - {1}", lightSource.lightSourceManufacturer, lightSource.lightSourceName));
                    }
                    else
                    {
                        /* Take no action */
                    }
                }
                else
                {
                    listBox1.Items.Add(string.Format("{0} - {1}", lightSource.lightSourceManufacturer, lightSource.lightSourceName));
                }
            }

            //String test  = (ConfigurationManager.AppSettings["PathData"] + "\\test.csv");

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
                cSpectrometer spectrometer = new();

                var error = spectrometer.Initialise(ConfigurationManager.AppSettings["PathCalFile"], settings);

                if(error == cSpectrometer.ErrorMessage.None)
                {
                    
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
            FormCapture formCapture = new();

            if (formCapture.ShowDialog(this) == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Would you like to save the data?", "Query?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DateTime timestamp = DateTime.Now;

                    // Save csv
                    

                    // Save to db
                }
                else
                {
                    MessageBox.Show("Data not saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

            }
        }
    }
}