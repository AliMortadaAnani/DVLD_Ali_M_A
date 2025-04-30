using DVLD_Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Ali_M_A
{
    public partial class frmMenu : Form
    {
        public frmLogin loginForm;
        public frmMenu(frmLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void MenuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPeople_Click(object sender, EventArgs e)
        {
            frmPeople people = new frmPeople();
            lbMenuPeople.StateNormal.ShortText.Color1 = Color.RebeccaPurple;
            people.ShowDialog();
            lbMenuPeople.StateNormal.ShortText.Color1 = Color.Gainsboro;
        }

        private void MenuSettings_Click(object sender, EventArgs e)
        {

            frmAccountSettings settings = new frmAccountSettings(this);
            lbMenuSettings.StateNormal.ShortText.Color1 = Color.RebeccaPurple;
            settings.ShowDialog();
            lbMenuSettings.StateNormal.ShortText.Color1 = Color.Gainsboro;
        }

        private void lbMenuUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            lbMenuUsers.StateNormal.ShortText.Color1 = Color.RebeccaPurple;
            users.ShowDialog();
            lbMenuUsers.StateNormal.ShortText.Color1 = Color.Gainsboro;
        }

        private void lbMenuApplications_Click(object sender, EventArgs e)
        {
            frmApplications applications = new frmApplications();
            lbMenuApplications.StateNormal.ShortText.Color1 = Color.RebeccaPurple;
            applications.ShowDialog();
            lbMenuApplications.StateNormal.ShortText.Color1 = Color.Gainsboro;
        }
    }
}
