using System.Configuration;

namespace Capture
{
    public partial class FormCapture : Form
    {
        private readonly mSpectrometerSettings SpectrometerSettings = new();

        private cSpectrometer spectrometer = new();

        public FormCapture()
        {
            InitializeComponent();
        }

        private void buttonCaptureDarkScan_Click(object sender, EventArgs e)
        {
            spectrometer.DarkScan();
        }

        private void buttonCaptureIrradiance_Click(object sender, EventArgs e)
        {
            double collectionArea = Convert.ToDouble(ConfigurationManager.AppSettings.Get("Collection Area"));
            spectrometer.LightScan();
            spectrometer.ProcessSpectrum(SpectrometerSettings.IntegrationTime, collectionArea);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
