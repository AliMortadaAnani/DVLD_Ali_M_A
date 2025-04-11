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
using DVLD_DataTypes;
using System.Diagnostics.Contracts;

namespace DVLD_Presentation
{
    public partial class ctrlPeopleShowDetails : UserControl
    {

        int _PersonID;
        clsPeople _Person;

        public int myIntProperty { get; set; }
        public ctrlPeopleShowDetails()
        {
            InitializeComponent();

           
        }

        
        private static string PersonGender(enGender gender)
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
        private void _LoadData()
        {
         //   if (!this.DesignMode)
              {  _PersonID = myIntProperty;
            _Person = clsPeople.Find(_PersonID);
            /*if (_Person == null)
            {
                MessageBox.Show("Person with id:" + _PersonID + " not found.");
                ParentForm.Close();
                return;
            }*/
            lblPid.Text = _Person.ID.ToString();
            lblPname.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.LastName;
            lblPnationalnb.Text = _Person.NationalNb;
            lblPgender.Text = PersonGender(_Person.Gender);
            lblPcountry.Text = clsCountry.Find(_Person.NationalCountryID).CountryName;
            lblPdateofbirth.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            lblPemail.Text = _Person.Email;
            lblPphone.Text = _Person.Phone;
            lblPaddress.Text = _Person.Address;

                if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
                {
                    pbPeopleDetails.Load(_Person.ImagePath);
                }
            }

        }

        private void btnPeopleEdit_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void ctrlPeopleShowDetails_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
