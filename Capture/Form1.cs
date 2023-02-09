using System.Collections.Generic;

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
            listBox1.Items.Clear();
        }

        private void addMicrscopeManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddManufacturer microscopeManufacturer = new()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                Height = 200,
                Width = 300
            };

            if (microscopeManufacturer.ShowDialog(this) == DialogResult.OK)
            {
                String? newMicroscopeManufacturerName = microscopeManufacturer.name;

                if (newMicroscopeManufacturerName.Length > 0)
                {
                    var manufacturers = db.readMicroscopeManufacturer();

                    var result = manufacturers.Find(manufacturers => manufacturers.name == newMicroscopeManufacturerName);

                    if (result != null)
                    {
                        MessageBox.Show("The Microscope Manufacturer is already listed.");
                    }
                    else
                    {
                        db.writeMicroscopeManufacturer(newMicroscopeManufacturerName);
                    }
                }
            }
            else
            {
                /* Take no action. */
            }

            microscopeManufacturer.Dispose();
        }

        private void addLightSourceManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddManufacturer lightSourceManufacturer = new()
            {
                FormBorderStyle = FormBorderStyle.FixedSingle,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                Height = 200,
                Width = 300
            };

            if (lightSourceManufacturer.ShowDialog(this) == DialogResult.OK)
            {
               String? newLightSourceManufacturerName = lightSourceManufacturer.name;

                if (newLightSourceManufacturerName.Length > 0)
                {
                    var manufacturers = db.readLightSourceManufacturer();

                    var result = manufacturers.Find(manufacturers => manufacturers.name == newLightSourceManufacturerName);

                    if (result != null)
                    {
                        MessageBox.Show("The Light Source Manufacturer is already listed.");
                    }
                    else
                    {
                        db.writeLightSourceManufacturer(newLightSourceManufacturerName);
                    }
                }
            }
            else
            {
                /* Take no action. */
            }

            lightSourceManufacturer.Dispose();
        }

        private void addLightSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddScopeOrLight addLight = new()
            {
                Text = "Add Light Source"
            };

            if(addLight.ShowDialog(this) == DialogResult.OK)
            {

            }
            else
            {
                /* Cancelled */
            }
        }

        private void addMicroscopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddScopeOrLight addMicroscope = new()
            {
                Text = "Add Microscope"
            };

            if (addMicroscope.ShowDialog(this) == DialogResult.OK)
            {

            }
            else
            {
                /* Cancelled */
            }
        }
    }
}