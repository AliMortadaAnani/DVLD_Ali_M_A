using DVLD_Business;
using DVLD_Data;
using DVLD_DataTypes;
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
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084); // Fixed size

            // Move form to the right side of the screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            _RefreshPeopleList();

        }

        private void PeopleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshPeopleList()
        {
            dgvPeople.DataSource = clsPeople.GetAllPeople();
            PeopleTotalRecordsNb.Text = clsPeople.GetPeopleTotalRecords().ToString();
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (kryptonComboBox1.SelectedIndex == kryptonComboBox1.FindString("name"))
            {
                dgvPeople.DataSource = clsPeople.GetPeopleByFirstName(kryptonTextBox1.Text);
                PeopleTotalRecordsNb.Text = dgvPeople.RowCount.ToString();
            }
        }
    }
}
