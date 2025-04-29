namespace DVLD_Presentation
{
    public partial class frmPeopleAddUpdate : Form
    {   
        public  int _PersonID_Back;
        public frmPeopleAddUpdate(int _PersonID)
        {
            InitializeComponent();
            ctrlPeopleAddUpdate._PersonID = _PersonID;
            ctrlPeopleAddUpdate1.DataBack += Id_DataBack;

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

        private void frmPeopleAddUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Id_DataBack(object sender, int PersonID)
        {
            _PersonID_Back = PersonID;


        }

    }
}
