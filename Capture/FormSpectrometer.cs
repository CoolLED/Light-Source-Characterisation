using System.Configuration;

namespace Capture
{
    public partial class FormSpectrometer : Form
    {
        public mSpectrometerSettings spectrometerSettings = new();

        public FormSpectrometer()
        {
            InitializeComponent();
        }

        private void Spectrometer_Load(object sender, EventArgs e)
        {
            checkBoxStrobeEn.Checked = false;

            maskedTextBox1.Text = "100";

            comboBoxIntTime.SelectedIndex = 0;

            numericUpDownScansToAverage.Minimum = 1;
            numericUpDownScansToAverage.Maximum = 100;
            numericUpDownScansToAverage.Value = 1;
            numericUpDownScansToAverage.Increment = 1;

            numericUpDownBoxcarWidth.Minimum = 0;
            numericUpDownBoxcarWidth.Maximum = 100;
            numericUpDownBoxcarWidth.Value = 0;
            numericUpDownBoxcarWidth.Increment = 1;

            checkBoxElectricDark.Checked = true;

            checkBoxNonlinearityCorrection.Checked = false;

            comboBoxTrigMode.SelectedIndex = 0;
            comboBoxTrigMode.Enabled = false;
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            spectrometerSettings.StrobEnable = checkBoxStrobeEn.Checked; 

            spectrometerSettings.IntegrationTime = Int32.Parse(maskedTextBox1.Text);

            switch (comboBoxIntTime.SelectedIndex)
            {
                case 1:
                    spectrometerSettings.IntegrationTime *= 1000;
                    break;
                case 2:
                    spectrometerSettings.IntegrationTime *= 1000000;
                    break;

                default: break;
            }

            spectrometerSettings.ScansToAverage = (int)numericUpDownScansToAverage.Value;

            spectrometerSettings.BoxcarWidth = (int)numericUpDownBoxcarWidth.Value;

            spectrometerSettings.ElectricDark = checkBoxElectricDark.Checked;

            spectrometerSettings.NonlinearityCorrection = checkBoxNonlinearityCorrection.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
