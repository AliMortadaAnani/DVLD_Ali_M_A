using DVLD_Business;
using DVLD_General;
using DVLD_Presentation.Properties;
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
    public partial class frmInternationalLicenseShowDetails : frmGeneral
    {
        int _IntLicenseID { get; set; }
        clsInternationalLicense _License;
        clsPeople _Person;
        public frmInternationalLicenseShowDetails(int InternationalLicenseID)
        {
            InitializeComponent();
            lblGeneralTitle.Text = "International License Details";
            _IntLicenseID = InternationalLicenseID;
        }

        private void frmInternationalLicenseShowDetails_Load(object sender, EventArgs e)
        {
            _License = clsInternationalLicense.GetLicense(_IntLicenseID);
            _Person = clsPeople.Find(clsApplication.GetApplicationByID(_License.ApplicationID).ApplicantPersonID);

            txtappID.Text = _License.ApplicationID.ToString();
            txtILid.Text = _License.ID.ToString();
            licenseidtxt.Text = _License.IssuedUsingLocalLicenseID.ToString();
            
            issuedatetxt.Text = _License.IssueDate.ToString("dd/MM/yyyy");
            exptxt.Text = _License.ExpirationDate.ToString("dd/MM/yyyy");
            nametxt.Text = _Person.FirstName + " " + _Person.LastName;
          
            natnbtxt.Text = _Person.NationalNb;
            gendertxt.Text = ctrlPeopleShowDetails.PersonGender(_Person.Gender);
            birthdattxt.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
           
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
            


        }
    }
}
