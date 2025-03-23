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
            //ho
        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {
            kryptonTextBox2.UseSystemPasswordChar = true;
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = kryptonPanel2;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            frmPeoples frm = new frmPeoples();
            frm.ShowDialog();
        }
       
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
