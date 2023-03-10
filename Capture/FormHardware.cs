using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public partial class FormHardware : Form
    {
        public Model_Catalogue hardware = new Model_Catalogue();

        public FormHardware()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addHardware();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Model_Catalogue addHardware()
        {
            hardware.lightSourceName = textBoxLightsourceName.Text.ToUpper();
            hardware.lightSourceManufacturer = textBoxLightsourceManufacturer.Text.ToUpper();
            hardware.microscope = textBoxMicroscope.Text.ToUpper();
            hardware.microscopeObjective = textBoxMicroscopeObjective.Text.ToUpper();

            return hardware;
        }

        public bool checkTableExists(List<Model_Table_Name> tables)
        {
            bool exists = false;

            String TableName = hardware.lightSourceManufacturer + "__" + hardware.lightSourceName +
                   "__" + hardware.microscope + "__" + hardware.microscopeObjective;
            TableName = TableName.Replace(' ', '_');

            var searchResult = tables.Find(tables => tables.TABLE_NAME == TableName);

            if (searchResult == null)
            {
                exists = false;
            }
            else
            {
                exists = true;
            }

            return exists;
        }
    }
}