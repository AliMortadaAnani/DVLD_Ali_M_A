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
    public partial class frmMenue : Form
    {
        public frmMenue()
        {
            InitializeComponent();
        }

        private void MenueCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuePeople_Click(object sender, EventArgs e)
        {
            frmPeople people = new frmPeople();
            people.ShowDialog();
        }

        private void MenueSettings_Click(object sender, EventArgs e)
        {   
            
            frmAccountSettings settings = new frmAccountSettings();
            settings.ShowDialog();
        }
    }
}
