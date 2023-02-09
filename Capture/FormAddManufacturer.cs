namespace Capture
{
    public partial class FormAddManufacturer : Form
    {
        public String? name { get; set; }

        public FormAddManufacturer()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.name = textBoxManufacturer.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
