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
        public FormHardware()
        {
            InitializeComponent();
        }

        public Model_Catalogue addHardware()
        {
            Model_Catalogue hardware = new Model_Catalogue();

            hardware.lightSourceName = textBoxLightsourceName.Text;
            hardware.lightSourceManufacturer = textBoxLightsourceManufacturer.Text;
            hardware.microscope = textBoxMicroscope.Text;
            hardware.microscopeObjective = textBoxMicroscopeObjective.Text;

            return hardware;
        }
    }
}
