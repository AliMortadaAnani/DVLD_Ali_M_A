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
    public partial class frmLocalDLA_Main : frmGeneral
    {
        public frmLocalDLA_Main()
        {
            InitializeComponent();

        }

        private void frmLocalDLA_Main_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1570, 1084);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);


            dgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _RefreshLocalList();
            _RefreshFilterInput();
        }


        private void _RefreshLocalList()
        {
            dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA();
            lblLocalTotalRecordsNb.Text = dgvLocal.RowCount.ToString();
        }
        private void _RefreshFilterInput()
        {
            if (cbLocalFilterBox.SelectedIndex == cbLocalFilterBox.FindString("None"))
            {
                mtbLocalFilterInput.Visible = false;
                cbLocalStatusOptions.Visible = false;
            }
        }







        /*private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete user with id : " + dgvUsers.CurrentRow.Cells[0].Value + "", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshLocalList();
                }

                else
                    MessageBox.Show("User is not deleted because it's linked to other data.");

            }
        }*/





        private void cbLocalFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLocalStatusOptions.Visible = false;
            cbLocalStatusOptions.SelectedIndex = cbLocalStatusOptions.FindString("All");
            mtbLocalFilterInput.Visible = true;
            _RefreshLocalList();
            switch (cbLocalFilterBox.SelectedItem?.ToString())
            {
                case "None":
                    mtbLocalFilterInput.Visible = false;
                    _RefreshLocalList();
                    break;

                case "ID":

                    mtbLocalFilterInput.Text = string.Empty;
                    mtbLocalFilterInput.Mask = "000000";
                    mtbLocalFilterInput.Focus();
                    break;

                case "Status":
                    mtbLocalFilterInput.Visible = false;
                    cbLocalStatusOptions.Visible = true;
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA();
                    break;

                default:
                    mtbLocalFilterInput.Text = string.Empty;
                    mtbLocalFilterInput.Mask = null;
                    mtbLocalFilterInput.Focus();
                    break;
            }
        }



        private void cbLocalStatusOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLocalStatusOptions.SelectedItem?.ToString())
            {
                case "All":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA();
                    break;


                case "New":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus("New");
                    break;

                case "Cancelled":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus("Cancelled");
                    break;

                case "Completed":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus("Completed");
                    break;
            }
            lblLocalTotalRecordsNb.Text = dgvLocal.RowCount.ToString();
        }

        private void mtbLocalFilterInput_TextChanged(object sender, EventArgs e)
        {
            string input = mtbLocalFilterInput.Text.Trim();

            string selectedFilter = cbLocalFilterBox.Text;

            switch (selectedFilter)
            {
                case "ID":
                    if (int.TryParse(input, out int id))
                    {
                        dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByID(id);
                    }
                    break;




                case "NationalNumber":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByNationalNb(input);
                    break;

                case "FullName":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByFulllName(input);
                    break;

                case "Status":
                    dgvLocal.DataSource = clsLocal_DLA.GetAllLocal_DLA_ByStatus(input);
                    break;

            }
            lblLocalTotalRecordsNb.Text = dgvLocal.RowCount.ToString();
        }

        private void CancelApplicationtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLocal.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to Cancel local application with id : " + id + "", "Confirm Cancellation", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                enApplicationStatus status = clsLocal_DLA.GetLocalDLA_Status(id);

                if (status == enApplicationStatus.New)
                {
                    clsApplication.UpdateApplication_Status_LastStatusDate(clsLocal_DLA.GetLocalDLAByID(id).ApplicationID, enApplicationStatus.Cancelled, DateTime.Now);
                    MessageBox.Show("Application Cancelled Successfully.");
                    _RefreshLocalList();
                }
                else
                    MessageBox.Show("Application cannot be cancelled.");



            }
        }

        private void btnLocalAddNew_Click(object sender, EventArgs e)
        {
            frmLocal_DLA_AddUpdate frm = new frmLocal_DLA_AddUpdate(-1, -1);
            frm.ShowDialog();
            _RefreshLocalList();
        }



        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nationalNb = dgvLocal.CurrentRow.Cells[2].Value.ToString();
            int id = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int personId = clsPeople.Find(nationalNb).ID;


            enApplicationStatus status = clsLocal_DLA.GetLocalDLA_Status(id);

            if (status == enApplicationStatus.New)
            {
                frmLocal_DLA_AddUpdate frm = new frmLocal_DLA_AddUpdate(personId, id);
                frm.ShowDialog();
                _RefreshLocalList();
            }
            else
                MessageBox.Show("Application cannot be updated.");
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete local application with id : " + dgvLocal.CurrentRow.Cells[0].Value + "", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Perform Delele and refresh
                if (clsLocal_DLA.DeleteLocalDLA((int)dgvLocal.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Deleted Successfully.");
                    _RefreshLocalList();
                }
                else
                    MessageBox.Show("Application is not deleted because it's linked to other data.");
            }
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int appid = clsLocal_DLA.GetLocalDLAByID(localid).ApplicationID;
            frmLocal_DLA_ShowDetails frm = new frmLocal_DLA_ShowDetails(localid, appid);
            frm.ShowDialog();
            _RefreshLocalList();
        }





        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int appid = clsLocal_DLA.GetLocalDLAByID(localid).ApplicationID;
            frmTestAppointments frm = new frmTestAppointments(enTestType.Vision, appid, localid);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void contextMenuStripLocal_Opening(object sender, CancelEventArgs e)
        {
            int LocalID = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int ApplicationID = clsLocal_DLA.GetLocalDLAByID(LocalID).ApplicationID;
            int PersonID = clsApplication.GetApplicationByID(ApplicationID).ApplicantPersonID;
            int LicenseClassID = clsLocal_DLA.GetLocalDLAByID(LocalID).LicenseClassID;
            string status_string = (string)dgvLocal.CurrentRow.Cells[6].Value;
            int passed_tests = (int)dgvLocal.CurrentRow.Cells[5].Value;
            bool HasLicense = clsLicense.CheckPersonHasLicenseClass(PersonID, LicenseClassID);

            showApplicationToolStripMenuItem.Enabled = true;

            CancelApplicationtoolStripMenuItem1.Enabled = Cancel(status_string) && !HasLicense;
            updateApplicationToolStripMenuItem.Enabled = Update(status_string, passed_tests) && !HasLicense;
            deleteApplicationToolStripMenuItem.Enabled = Delete(status_string);
            scheduleTestToolStripMenuItem.Enabled = Schedule(status_string, passed_tests) && !HasLicense;
            visionTestToolStripMenuItem.Enabled = Schedulevision(passed_tests);
            writtenTestToolStripMenuItem.Enabled = Schedulewritten(passed_tests);
            drivingTestToolStripMenuItem1.Enabled = Scheduledriving(passed_tests);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = IssueLicense(passed_tests, status_string) && !HasLicense;
            showLicenseHistoryToolStripMenuItem.Enabled = ShowLicense(passed_tests, status_string) && HasLicense;
            showLicenseStripMenuItem.Enabled = ShowLicense(passed_tests, status_string) && HasLicense;
        }

        bool Cancel(string status)
        {
            if (status == "New")
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        bool Update(string status, int passed)
        {
            if (status == "New" && passed == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Delete(string status)
        {
            if (status == "Completed")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool Schedule(string status, int passed)
        {
            if (status == "New" && passed != 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Schedulevision(int passed)
        {
            if (passed == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Schedulewritten(int passed)
        {
            if (passed == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Scheduledriving(int passed)
        {
            if (passed == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IssueLicense(int passed, string status)
        {
            if (passed == 3 && status == "New")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool ShowLicense(int passed, string status)
        {
            if (passed == 3 && status == "Completed")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int appid = clsLocal_DLA.GetLocalDLAByID(localid).ApplicationID;
            frmTestAppointments frm = new frmTestAppointments(enTestType.Written, appid, localid);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void drivingTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int localid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int appid = clsLocal_DLA.GetLocalDLAByID(localid).ApplicationID;
            frmTestAppointments frm = new frmTestAppointments(enTestType.Driving, appid, localid);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int appid = clsLocal_DLA.GetLocalDLAByID(localid).ApplicationID;
            frmIssueLicense frm = new frmIssueLicense(appid, localid);
            frm.ShowDialog();
            _RefreshLocalList();
        }

        private void showLicenseStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int appid = clsLocal_DLA.GetLocalDLAByID(localid).ApplicationID;
            int licenseid = clsLicense.GetLicenseByAppID(appid).ID;
            frmShowLicense frm = new frmShowLicense(licenseid);
            frm.ShowDialog();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localid = (int)dgvLocal.CurrentRow.Cells[0].Value;
            int appid = clsLocal_DLA.GetLocalDLAByID(localid).ApplicationID;
            int personid = clsApplication.GetApplicationByID(appid).ApplicantPersonID;
            frmShowLicenseHistory frm = new frmShowLicenseHistory(personid);
            frm.ShowDialog();
            _RefreshLocalList();
        }
    }
}
