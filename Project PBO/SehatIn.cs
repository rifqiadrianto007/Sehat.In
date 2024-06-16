namespace Project_PBO
{
    public partial class SehatIn : Form
    {
        public SehatIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();
            newForm.Show();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
        }
    }
}
