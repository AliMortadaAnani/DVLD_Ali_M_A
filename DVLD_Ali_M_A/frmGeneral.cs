using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();

        }

        public void frmGeneral_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

        }

        public void btnGeneralCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
