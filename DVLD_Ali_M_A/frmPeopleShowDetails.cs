namespace DVLD_Presentation
{
    public partial class frmPeopleShowDetails : Form
    {
        public frmPeopleShowDetails(int _PersonID)
        {
            InitializeComponent();
            ctrlPeopleShowDetails._PersonID = _PersonID;
        }

        private void btnPeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPeopleShowDetails_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }
    }
}
