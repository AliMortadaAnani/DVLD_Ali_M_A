using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public int PersonID { get; set; }
        public int CreateByUserID { get; set; }
        public DateTime CreatedDate { get; set; }


        public clsDriver()
        {
            ID = -1;
            PersonID = -1;
            CreateByUserID = -1;
            CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsDriver(int id, int personID, int createByUserID, DateTime createdDate)
        {
            ID = id;
            PersonID = personID;
            CreateByUserID = createByUserID;
            CreatedDate = createdDate;
            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.ID = clsDriversData.AddDriver(PersonID, CreateByUserID, CreatedDate);
            return (this.ID != -1);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        return true;
                    }
                    break;
                case enMode.Update:
                    // Implement update logic here if needed
                    break;
            }
            return false;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriversData.GetAllDrivers();
        }
        public static DataTable GetAllDriversByPersonID(int PersonID)
        {
            return clsDriversData.GetAllDriversByPersonID(PersonID);
        }
        public static DataTable GetAllDriversByID(int ID)
        {
            return clsDriversData.GetAllDriversByID(ID);
        }

        public static DataTable GetAllDriversByFullName(string FullName)
        {
            return clsDriversData.GetAllDrivers_ByFullName(FullName);
        }

        public static DataTable GetAllDriversByNationalNumber(string NationalNumber)
        {
            return clsDriversData.GetAllDrivers_BynationalNb(NationalNumber);
        }

        public static DataTable GetAllDriversByIssueDate(string IssueDate)
        {
            return clsDriversData.GetAlldriversByIssueDate(IssueDate);
        }

        public static DataTable GetAllDriversByLicensesNumber(int Number)
        {
            return clsDriversData.GetAllDriversByActiveLicenses(Number);
        }

        public static bool IsDriverExist(int ID)
        {
            return clsDriversData.IsDriverExist(ID);
        }

        public bool DeleteDriver(int ID)
        {
            if(clsDriversData.CheckDriverIntegrity(ID))
            {
                return false;
            }
            else
            {
                return clsDriversData.DeleteDriver(ID);
            }
        }
    }
}
