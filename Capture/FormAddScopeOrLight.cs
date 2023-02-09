using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public partial class FormAddScopeOrLight : Form
    {

        public eType type;

        public String manufacturer;
        public String name;
        public FormAddScopeOrLight()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(type == eType.lightsource)
            {

            }
            else
            {

            }

            manufacturer = comboBox1.Text;
            name = textBox1.Text;
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
