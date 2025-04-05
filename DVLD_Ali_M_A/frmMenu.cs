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
        public frmMenu()
        {
            InitializeComponent();
        }

        private void MenuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPeople_Click(object sender, EventArgs e)
        {
            frmPeople people = new frmPeople();
            MenuPeople.StateNormal.ShortText.Color1 = Color.RebeccaPurple;
            people.ShowDialog();
            MenuPeople.StateNormal.ShortText.Color1 = Color.Gainsboro;
        }

        private void MenuSettings_Click(object sender, EventArgs e)
        {   
            
            frmAccountSettings settings = new frmAccountSettings();
            MenuSettings.StateNormal.ShortText.Color1 = Color.RebeccaPurple;
            settings.ShowDialog();
            MenuSettings.StateNormal.ShortText.Color1 = Color.Gainsboro;
        }
    }
}
