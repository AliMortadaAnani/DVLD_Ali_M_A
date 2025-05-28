using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_General;
using DVLD_Presentation.Properties;

namespace DVLD_Presentation
{
    public partial class ctrlLicenseInfo : UserControl
    {   
        public int _LicenseID { get; set; }
        clsLicense _License;
        clsPeople _Person;
        public ctrlLicenseInfo()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.Load += ctrlLicenseInfo_Load;
            }

           
        }

        private void ctrlLicenseInfo_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                _LoadData();
        }
        private void ResetAllFields()
        {
            // Text fields
            licenseidtxt.Text = string.Empty;
            licensetxt.Text = string.Empty;
            issuedatetxt.Text = string.Empty;
            exptxt.Text = string.Empty;
            nametxt.Text = string.Empty;
            notetxtfield.Text = string.Empty;
            natnbtxt.Text = string.Empty;
            gendertxt.Text = string.Empty;
            birthdattxt.Text = string.Empty;
            reasontxtt.Text = string.Empty;
            driveridtxt.Text = string.Empty;
            activetxt.Text = string.Empty;
            detainedtxt.Text = string.Empty;

            // Image
            pbPeopleDetails.Image = null;  // or set to a default image

            
        }
        public void _LoadData()
        {
           if(_LicenseID <= 0)
            {
                ResetAllFields();  
                return;
            }
            this._License = clsLicense.GetLicense(_LicenseID);
            _Person = clsPeople.Find(clsApplication.GetApplicationByID(_License.ApplicationID).ApplicantPersonID);



            licenseidtxt.Text = _License.ID.ToString();
            licensetxt.Text = clsLicenseClass.Find(_License.LicenseClass).ClassName;
            issuedatetxt.Text = _License.IssueDate.ToString("dd/MM/yyyy");
            exptxt.Text = _License.ExpirationDate.ToString("dd/MM/yyyy");
            nametxt.Text = _Person.FirstName + " " + _Person.LastName;
            notetxtfield.Text = _License.Notes;
            if(notetxtfield.Text == "")
            {
                notetxtfield.Text = "No Notes";
            }
            natnbtxt.Text = _Person.NationalNb;
            gendertxt.Text = ctrlPeopleShowDetails.PersonGender(_Person.Gender);
            birthdattxt.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            reasontxtt.Text = GetIssueReason((enIssueReason)_License.IssueReason);
            driveridtxt.Text = _License.DriverID.ToString();
            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(ctrlPeopleAddUpdate.MyImage(_Person.ImagePath)))
            {

                using (var img = System.Drawing.Image.FromFile(ctrlPeopleAddUpdate.MyImage(_Person.ImagePath)))
                {
                    pbPeopleDetails.Image = new Bitmap(img); // Copy image, release lock
                }

            }
            else
            {
                if (gendertxt.Text == "female")
                    pbPeopleDetails.Image = Resources.female;
                if (gendertxt.Text == "male")
                    pbPeopleDetails.Image = Resources.male3;
            }

            if (_License.IsActive)
            {
                activetxt.Text = "Yes";
             
            }
            else
            {
                activetxt.Text = "No";
              
            }
            if(clsLicense.IsLicenseDetained(_License.ID))
            {
                detainedtxt.Text = "Yes";
            }
            else
            {
                detainedtxt.Text = "No";
            }


        }

        public static string GetIssueReason(enIssueReason reason)
        {
            switch (reason)
            {
                case enIssueReason.FirstTime:
                    return "First Time License";
                case enIssueReason.Renew:
                    return "Renew License";
                case enIssueReason.Replacement_for_Lost:
                    return "Replacement for Lost License";
                case enIssueReason.Replacement_for_Damaged:
                    return "Replacement for Damaged License";
                default:
                    return "Unknown";
            }
        }
    }
}
