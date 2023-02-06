namespace Capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void ButtonAddLightSource_Click(object sender, EventArgs e)
        {
            FormAddLightSource ls = new()
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            ls.Show();
        }


        private void ButtonAddMicroscope_Click(object sender, EventArgs e)
        {

        }
    }
}