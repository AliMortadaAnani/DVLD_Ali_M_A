using DVLD_Business;
using DVLD_General;
using DVLD_Presentation.Properties;

namespace DVLD_Presentation
{
    public partial class ctrlPeopleShowDetails : UserControl
    {
        private clsPeople _Person;

        public static int _PersonID { get; set; }

        public ctrlPeopleShowDetails()
        {
            InitializeComponent();

            // Protect against crashing in design mode // GPT
            if (!this.DesignMode)
            {
                this.Load += ctrlPeopleShowDetails_Load;
            }
        }

        private void ctrlPeopleShowDetails_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                _LoadData();
        }

        public static string PersonGender(enGender gender)
        {
            if (gender == enGender.Male)
            {
                return "male";
            }
            else
            {
                return "female";
            }
        }

        public void _LoadData()
        {
            if (_PersonID <= 0)
            {
                btnPeopleEdit.Enabled = false;
                return;
            }
            btnPeopleEdit.Enabled = true;
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                if (!this.DesignMode)
                {
                    MessageBox.Show("Person with ID: " + _PersonID + " not found.");
                    ParentForm?.Close(); // Safe null-check
                }
                return;
            }

            lblPid.Text = _Person.ID.ToString();
            lblPname.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.LastName;
            lblPnationalnb.Text = _Person.NationalNb;
            lblPgender.Text = PersonGender(_Person.Gender);
            lblPcountry.Text = clsCountry.Find(_Person.NationalCountryID).CountryName;
            lblPdateofbirth.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            lblPemail.Text = _Person.Email;
            lblPphone.Text = _Person.Phone;
            lblPaddress.Text = _Person.Address;

            if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(ctrlPeopleAddUpdate.MyImage(_Person.ImagePath)))
            {

                using (var img = System.Drawing.Image.FromFile(ctrlPeopleAddUpdate.MyImage(_Person.ImagePath)))
                {
                    pbPeopleDetails.Image = new Bitmap(img); // Copy image, release lock
                }

            }
            else
            {
                if (lblPgender.Text == "female")
                    pbPeopleDetails.Image = Resources.female;
                if (lblPgender.Text == "male")
                    pbPeopleDetails.Image = Resources.male3;
            }

        }

        private void btnPeopleEdit_Click(object sender, EventArgs e)
        {
            frmPeopleAddUpdate frmPeopleAddUpdate = new frmPeopleAddUpdate(_PersonID);
            frmPeopleAddUpdate.ShowDialog();
            _LoadData();
        }
    }
}
