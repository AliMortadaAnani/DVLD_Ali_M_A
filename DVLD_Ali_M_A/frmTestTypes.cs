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
    public partial class frmTestTypes : Form
    {
        public frmTestTypes()
        {
            InitializeComponent();
        }

        private void btnPeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

            dgvtests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            _RefreshTestTypesList();
        }


        private void _RefreshTestTypesList()
        {
            dgvtests.DataSource = clsTestType.GetAllTestTypes();
            lbltestsTotalRecordsNb.Text = clsTestType.GetTestTypeCount().ToString();
        }


        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestEdit testEdit = new frmTestEdit((int)dgvtests.CurrentRow.Cells[0].Value);
            testEdit.ShowDialog();
            _RefreshTestTypesList();
        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            string documentation = "This form displays records of test types.\nRight-clicking a test type opens a context menu with an option to edit the selected test type.";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }
}
