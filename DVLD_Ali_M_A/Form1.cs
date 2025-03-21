namespace DVLD_Ali_M_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            kryptonTextBox2.UseSystemPasswordChar = true;   
        }
    }
}
