namespace WinForms_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was pushed");
        }
    }
}