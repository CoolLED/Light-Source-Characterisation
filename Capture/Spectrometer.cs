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
    public partial class Spectrometer : Form
    {
        public Spectrometer()
        {
            InitializeComponent();
        }

        private void Spectrometer_Load(object sender, EventArgs e)
        {
            comboBoxIntTime.SelectedIndex=0;
        }
    }
}
