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
    public partial class frmLocal_DLA_AddUpdate : frmGeneral
    {
        int CurrentPersonId = -1;
        private bool AllowTabChange = false;
        public frmLocal_DLA_AddUpdate(int _PersonID, int _LocalID)
        {
            InitializeComponent();
            //btnDocumentation.Visible = true;
            ctrlPeopleShowDetails._PersonID = _PersonID;
            ctrlLocaldlA_AddUpdate1._ID = _LocalID;
            lblGeneralTitle.Text = "Add New Local DLA";
            lbLocalTitle.Text = "Add New Local DLA";
            if (_PersonID != -1 && _LocalID != -1)
            {
                ctrlPersonFilter1.Enabled = false;
                ctrlPersonFilter1.Visible = false;
                lblGeneralTitle.Text = "Edit Local DLA Details";
                lbLocalTitle.Text = "Edit Local DLA Details";
            }
        }









        private void ctrlPersonFilter1_OnPersonSearchComplete(int obj)
        {
            ctrlPeopleShowDetails._PersonID = obj;
            ctrlPeopleShowDetails1._LoadData();
            CurrentPersonId = obj;
        }

        private void btnLocalNext_Click(object sender, EventArgs e)
        {
            if (ctrlPeopleShowDetails._PersonID == -1)
            {
                MessageBox.Show("You should choose an existing person!");
                return;
            }
            /*else if (clsPeople.IsPersonUser(CurrentPersonId)
                && ctrlLocaldlA_AddUpdate1._ID == -1 && ctrlPersonFilter1.Enabled == true)
            {
                MessageBox.Show("This person is already a user!");
                return;
            }*/
            AllowTabChange = true;
            tabLocalControl.SelectedTab = pageLocal;
            AllowTabChange = false;
            btnLocalNext.Visible = false;
            btnLocalNext.Enabled = false;
            btnLocalBack.Visible = true;
            btnLocalBack.Enabled = true;

        }

        private void tabUserControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!AllowTabChange)
                e.Cancel = true; // Prevent tab change
        }

        private void btnLocalBack_Click(object sender, EventArgs e)
        {
            ctrlPersonFilter1.Enabled = false;
            ctrlPersonFilter1.Visible = false;
            AllowTabChange = true;
            tabLocalControl.SelectedTab = pagePerson;
            AllowTabChange = false;
            btnLocalBack.Visible = false;
            btnLocalBack.Enabled = false;
            btnLocalNext.Visible = true;
            btnLocalNext.Enabled = true;


        }

        private void frmLocal_DLA_AddUpdate_Load(object sender, EventArgs e)
        {
            btnLocalBack.Visible = false;
            btnLocalBack.Enabled = false;
        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
           

        }

        private void btnDocumentation_Click_1(object sender, EventArgs e)
        {
            string documentation = "This form contains two tab pages.\nThe first tab allows you to select an existing person or add a new person to create a new local driving license application.\nYou cannot navigate to the application tab until a person is selected.\nOnce a person is chosen and you move to the application tab, the selected person cannot be changed.\nUse the Save button to store the new application information.\nA person cannot have more than one active application for the same local license class, unless the previous one was cancelled.\nIf you change the local license type after saving, the new type will replace the previous one within the same application.";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }
}
