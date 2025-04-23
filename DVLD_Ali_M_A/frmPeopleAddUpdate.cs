namespace DVLD_Presentation
{
    public partial class frmPeopleAddUpdate : Form
    {
        public frmPeopleAddUpdate(int _PersonID)
        {
            InitializeComponent();
            ctrlPeopleAddUpdate._PersonID = _PersonID;
            if (_PersonID != -1)
                lblPeopleTitle.Text = "Edit Person Details";
        }

        private void btnPeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPeopleAddUpdate_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        
    }
}
