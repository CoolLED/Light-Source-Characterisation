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
        public DB_Hardware hardware = new DB_Hardware();
        public Model_Table_Name tableName = new Model_Table_Name();

        public FormHardware()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addHardware();
            tableName.TABLE_NAME = (string)comboBoxHardwareTables.SelectedItem;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void addHardware()
        {
            hardware.name = textBoxHardwareName.Text;
        }

        public void addTables(List<Model_Table_Name> tables)
        {
            foreach (Model_Table_Name table in tables)
            {
                if (table.TABLE_NAME != "catalogue")
                {
                    comboBoxHardwareTables.Items.Add(table.TABLE_NAME);
                }
            }

            return;
        }
    }
}