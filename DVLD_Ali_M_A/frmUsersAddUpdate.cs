using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmUsersAddUpdate : Form
    {
         int CurrentPersonId = -1;
        public frmUsersAddUpdate(int _PersonID,int _UserID)
        {
            InitializeComponent();
            ctrlPeopleShowDetails._PersonID = _PersonID;
            ctrlUsersAddUpdate._UserID = _UserID;
            lblUserTitle.Text = "Add New User";
            if (_PersonID != -1 && _UserID != -1)
            {
                ctrlPersonFilter1.Enabled = false;
                ctrlPersonFilter1.Visible = false;
                lblUserTitle.Text = "Edit User Details";
            }
        }

        private bool AllowTabChange = false;
        private void frmUsersAddUpdate_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            btnUserBack.Visible = false;
            btnUserBack.Enabled = false;

        }

        private void btnUsersCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ctrlPersonFilter1_OnPersonSearchComplete(int obj)
        {
            ctrlPeopleShowDetails._PersonID = obj;
            ctrlPeopleShowDetails1._LoadData();
            CurrentPersonId = obj;
        }

        private void btnUserNext_Click(object sender, EventArgs e)
        {
            if (ctrlPeopleShowDetails._PersonID == -1)
            {
                MessageBox.Show("You should choose an existing person!");
                return;
            }
            else if (clsPeople.IsPersonUser(CurrentPersonId)
                && ctrlUsersAddUpdate._UserID == -1 && ctrlPersonFilter1.Enabled == true)
            {
                MessageBox.Show("This person is already a user!");
                return;
            }
            AllowTabChange = true;
            tabUserControl.SelectedTab = pageUser;
            AllowTabChange = false;
            btnUserNext.Visible = false;
            btnUserNext.Enabled = false;
            btnUserBack.Visible = true;
            btnUserBack.Enabled = true;

        }

        private void tabUserControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!AllowTabChange)
                e.Cancel = true; // Prevent tab change
        }

        private void btnUserBack_Click(object sender, EventArgs e)
        {
            ctrlPersonFilter1.Enabled = false;
            ctrlPersonFilter1.Visible = false;
            AllowTabChange = true;
            tabUserControl.SelectedTab = pagePerson;
            AllowTabChange = false;
            btnUserBack.Visible = false;
            btnUserBack.Enabled = false;
            btnUserNext.Visible = true;
            btnUserNext.Enabled = true;


        }
    }
}
