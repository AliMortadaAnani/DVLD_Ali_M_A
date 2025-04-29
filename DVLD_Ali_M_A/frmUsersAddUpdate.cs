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
        public frmUsersAddUpdate(int _PersonID,int _UserID)
        {
            InitializeComponent();
            ctrlPeopleShowDetails._PersonID = _PersonID;
            ctrlUsersAddUpdate._UserID = _UserID;
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
        }

        private void btnUserNext_Click(object sender, EventArgs e)
        {
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
