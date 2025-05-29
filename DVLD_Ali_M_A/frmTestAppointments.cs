using DVLD_Business;
using DVLD_General;
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
    public partial class frmTestAppointments : frmGeneral
    {
        int localID = -1;
        int applicationID = -1;
        enTestType testType;
        DateTime maxAppointmentDate = DateTime.Now;
        public frmTestAppointments(enTestType testType, int ApplicationID, int LocalID)
        {
            InitializeComponent();
            lblGeneralTitle.Text = GetTestTypeName(testType) + " Test Appointment";
            ctrlApplicationShow1._ApplicationID = ApplicationID;
            ctrlLocal_dlA_Details1._LocalDLA_ID = LocalID;
            localID = LocalID;
            applicationID = ApplicationID;
            this.testType = testType;
            dgvTA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _RefreshList();


        }

        public static string GetTestTypeName(enTestType testType)
        {
            switch (testType)
            {
                case enTestType.Vision:
                    return "Vision";
                case enTestType.Written:
                    return "Written";
                case enTestType.Driving:
                    return "Driving";
                default:
                    return "Unknown";
            }
        }

        private void _RefreshList()
        {
            dgvTA.DataSource = clsTestAppointment.GetAllTestAppointmentsByTestTypeAndLocal_DLA_ID(localID, (int)testType);
            lblTotalRecordsNb.Text = dgvTA.RowCount.ToString();
        }

        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maxdate(ref maxAppointmentDate);
            int id = (int)dgvTA.CurrentRow.Cells[0].Value;

            frmTestSchedule testSchedule = new frmTestSchedule(testType, localID, id, maxAppointmentDate);
            testSchedule.ShowDialog();
            _RefreshList();

        }

        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTA.CurrentRow.Cells[0].Value;
            frmTests test = new frmTests(id);
            test.ShowDialog();
            ctrlLocal_dlA_Details1._LoadData();

            _RefreshList();
        }
        void maxdate(ref DateTime maxAppointmentDate)
        {
            maxAppointmentDate = DateTime.MinValue; // Initialize with the smallest possible date

            foreach (DataGridViewRow row in dgvTA.Rows)
            {
                // Skip the "new row" if AllowUserToAddRows = true
                if (!row.IsNewRow && row.Cells["AppointmentDate"].Value != null)
                {
                    DateTime currentDate;
                    // Try parsing the cell value to DateTime
                    if (DateTime.TryParse(row.Cells["AppointmentDate"].Value.ToString(), out currentDate))
                    {
                        // Update maxDate if currentDate is later
                        if (currentDate > maxAppointmentDate)
                        {
                            maxAppointmentDate = currentDate;
                        }
                    }
                }
            }

            // If no valid dates were found, handle accordingly
            if (maxAppointmentDate == DateTime.MinValue)
            {
                maxAppointmentDate = DateTime.Now; // Set to current date or handle as needed
                //MessageBox.Show("No valid dates found!");
            }
            else
            {

            }
            ;
        }

        private void btnTestAppAddNew_Click(object sender, EventArgs e)
        {

            maxdate(ref maxAppointmentDate);
            int passedtests = clsTestAppointment.GetPassedTestsByTestTypeForLocalDLA(localID, (int)testType);
            bool isTestAppointmentExist = clsTestAppointment.IsTestAppointmentByTestTypeExist_NotLocked(localID, (int)testType);

            if (passedtests > 0)
            {
                MessageBox.Show("You have already passed the test. You cannot schedule a new appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isTestAppointmentExist)
            {
                MessageBox.Show("You have already scheduled a test appointment. You cannot schedule a new appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                frmTestSchedule testSchedule = new frmTestSchedule(testType, localID, -1, maxAppointmentDate);
                testSchedule.ShowDialog();
                _RefreshList();
            }


        }

        private void contextMenuStripLocal_Opening(object sender, CancelEventArgs e)
        {
            int id = (int)dgvTA.CurrentRow.Cells[0].Value;
            bool isLocked = clsTestAppointment.GetTestAppointmentByID(id).IsLocked;
            if (isLocked)
            {
                updateApplicationToolStripMenuItem.Enabled = false;
                takeTestToolStripMenuItem.Enabled = false;
            }
            else
            {
                updateApplicationToolStripMenuItem.Enabled = true;
                takeTestToolStripMenuItem.Enabled = true;

            }
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {

        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            string documentation = "This form displays local license and application details.\nIt shows test records for the selected test type (vision, written, or driving).\nRight-clicking a test record opens a context menu to edit the appointment date or open a form to take test.\nUse the 'Add New Appointment' button to schedule a new test appointment.\nYou cannot add a new appointment if the test type has already been passed or if the appointment is not yet locked (test not taken).";
            frmDocumentation frmDocumentation = new frmDocumentation(documentation);
            frmDocumentation.ShowDialog();

        }
    }
}
