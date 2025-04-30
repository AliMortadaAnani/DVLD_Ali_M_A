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
    public partial class frmApplicationTypes : Form
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnPeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPeopleTotalRecords_Click(object sender, EventArgs e)
        {

        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

            dgvapps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _RefreshApplicationTypesList();
        }

        private void _RefreshApplicationTypesList()
        {
            dgvapps.DataSource = clsApplicationType.GetAllApplicationTypes();
            lblappsTotalRecordsNb.Text = clsApplicationType.GetApplicationTypeCount().ToString();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationEdit appEdit = new frmApplicationEdit((int)dgvapps.CurrentRow.Cells[0].Value);
            appEdit.ShowDialog();
            _RefreshApplicationTypesList();
        }
    }
}
