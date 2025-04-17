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
            this.Size = new Size(1570, 1084); // Fixed size

            // Move form to the right side of the screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }
    }
}
