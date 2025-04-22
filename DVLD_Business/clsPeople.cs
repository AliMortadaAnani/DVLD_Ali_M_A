using DVLD_Data;
using DVLD_DataTypes;
using System.Data;



namespace DVLD_Business
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string NationalNb { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public enGender Gender { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int NationalCountryID { get; set; }

        public string ImagePath { get; set; }

        public clsPeople()
        {
            this.ID = -1;
            this.NationalNb = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = enGender.Male;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsPeople(int ID, string nationalNb, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, enGender gendor, string address, string phone, string email, int nationalCountryID, string imagePath)

        {

            this.ID = ID;
            this.NationalNb = nationalNb;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalCountryID = nationalCountryID;
            this.ImagePath = imagePath;

            Mode = enMode.Update;
        }



        private bool _AddNewPerson()
        {
            //call DataAccess Layer 
            this.ID = clsPeopleData.AddNewPerson(this.NationalNb, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalCountryID, this.ImagePath);
            return (this.ID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 
            return clsPeopleData.UpdatePerson(this.ID, this.NationalNb, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalCountryID, this.ImagePath);
        }


        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }
            return false;
        }



        public static clsPeople Find(int ID)
        {
            string NationalNb = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            enGender Gender = enGender.Male;
            int NationalityCountryID = -1;


            if (clsPeopleData.GetPersonInfoByID(ID, ref NationalNb, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
                return new clsPeople(ID, NationalNb, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static bool DeletePerson(int ID)

        {  
            if(clsPeopleData.CheckPersonIntegrity(ID))
            {
                return false;
            }
            else
            {
                return clsPeopleData.DeletePerson(ID);
            }

        }

        public static bool IsPersonExist(int ID)
        {
            return clsPeopleData.IsPersonExist(ID);
        }


        public static int GetPeopleCount()
        {
            return clsPeopleData.TotalPeopleCount();
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }

        public static DataTable GetPeopleByNationalNb(string NationalNb)
        {
            return clsPeopleData.GetAllPeopleByNationalNb(NationalNb);
        }
        public static DataTable GetPeopleByID(int ID)
        {
            return clsPeopleData.GetAllPeopleByID(ID);
        }
        public static DataTable GetPeopleByFirstName(string FirstName)
        {
            return clsPeopleData.GetAllPeopleByFirstName(FirstName);
        }

        public static DataTable GetPeopleBySecondName(string SecondName)
        {
            return clsPeopleData.GetAllPeopleBySecondName(SecondName);
        }

        public static DataTable GetPeopleByThirdName(string ThirdName)
        {
            return clsPeopleData.GetAllPeopleByThirdName(ThirdName);
        }

        public static DataTable GetPeopleByLastName(string LastName)
        {
            return clsPeopleData.GetAllPeopleByLastName(LastName);
        }

        public static DataTable GetPeopleByDateOfBirth(string DateOfBirth)
        {
            return clsPeopleData.GetAllPeopleByDateOfBirth(DateOfBirth);
        }

        public static DataTable GetPeopleByGender(string Gender)
        {
            return clsPeopleData.GetAllPeopleByGender(Gender);
        }

        public static DataTable GetPeopleByAddress(string Address)
        {
            return clsPeopleData.GetAllPeopleByAddress(Address);
        }

        public static DataTable GetPeopleByPhone(string Phone)
        {
            return clsPeopleData.GetAllPeopleByPhone(Phone);
        }

        public static DataTable GetPeopleByEmail(string Email)
        {
            return clsPeopleData.GetAllPeopleByEmail(Email);
        }

        public static DataTable GetPeopleByNationality(string Nationality)
        {
            return clsPeopleData.GetAllPeopleByNationality(Nationality);
        }


        public static string GetGuid()
        {
            return clsPeopleData.GetGuid();
        }

        //public static DataTable SortPeople(DataTable dt, string Column, string Order)
        //{


        //    if (Order.ToLower() == "asc")
        //    {
        //        switch (Column.ToLower())
        //        {
        //            case "id":
        //                dt.DefaultView.Sort = "personId asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "nationalno":
        //                dt.DefaultView.Sort = "NationalNo asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "firstname":
        //                dt.DefaultView.Sort = "FirstName asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "secondname":
        //                dt.DefaultView.Sort = "SecondName asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "thirdname":
        //                dt.DefaultView.Sort = "ThirdName asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "lastname":
        //                dt.DefaultView.Sort = "LastName asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "dateofbirth":
        //                dt.DefaultView.Sort = "DateOfBirth asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "gendor":
        //                dt.DefaultView.Sort = "Gendor asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "address":
        //                dt.DefaultView.Sort = "Address asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "phone":
        //                dt.DefaultView.Sort = "Phone asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "email":
        //                dt.DefaultView.Sort = "Email asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;

        //            case "nationalcountryid":
        //                dt.DefaultView.Sort = "NationalCountryID asc";
        //                dt = dt.DefaultView.ToTable();
        //                break;



        //        }
        //    }

        //    else if (Order.ToLower() == "desc")
        //    {
        //        switch (Column.ToLower())
        //        {
        //            case "id":
        //                dt.DefaultView.Sort = "personId desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "nationalno":
        //                dt.DefaultView.Sort = "NationalNo desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "firstname":
        //                dt.DefaultView.Sort = "FirstName desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "secondname":
        //                dt.DefaultView.Sort = "SecondName desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "thirdname":
        //                dt.DefaultView.Sort = "ThirdName desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "lastname":
        //                dt.DefaultView.Sort = "LastName desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "dateofbirth":
        //                dt.DefaultView.Sort = "DateOfBirth desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "gendor":
        //                dt.DefaultView.Sort = "Gendor desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "address":
        //                dt.DefaultView.Sort = "Address desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "phone":
        //                dt.DefaultView.Sort = "Phone desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "email":
        //                dt.DefaultView.Sort = "Email desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //            case "nationalcountryid":
        //                dt.DefaultView.Sort = "NationalCountryID desc";
        //                dt = dt.DefaultView.ToTable();
        //                break;
        //        }
        //    }

        //    return dt;

        //}


        public static bool IsNationalNumberExist(string NationalNumber)
        {
            return clsPeopleData.IsNationalNumberExist(NationalNumber);
        }
    }
}
