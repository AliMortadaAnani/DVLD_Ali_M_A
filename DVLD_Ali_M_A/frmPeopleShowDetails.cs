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

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            string documentation = "This form displays detailed information about a person.\nYou can click the Edit button to open the Edit Person form.\nAfter closing the edit form, you will return to this details view.";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }
}
