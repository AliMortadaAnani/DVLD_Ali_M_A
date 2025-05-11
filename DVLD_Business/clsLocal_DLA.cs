using DVLD_Data;
using DVLD_General;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLocal_DLA
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        // Constructor
        public clsLocal_DLA()
        {
            ID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            Mode = enMode.AddNew;
        }
        private clsLocal_DLA(int id, int applicationID, int licenseClassID)
        {
            ID = id;
            ApplicationID = applicationID;
            LicenseClassID = licenseClassID;
            Mode = enMode.Update;
        }

        private bool _AddNewLocalDLA()
        {
            this.ID = clsLocal_DLA_Data.AddNewLocalDLA(ApplicationID, LicenseClassID);
            return (this.ID != -1);
        }
        private bool _UpdateLocalDLA()
        {
            return clsLocal_DLA_Data.UpdateLocalDLA_LicenseClass(ID, ApplicationID, LicenseClassID);
        }

        public  static bool UpdateLocalDLA_Status(int ID,enApplicationStatus Status)
        {
            return clsLocal_DLA_Data.UpdateLocalDLA_Status(ID,Status);
        }



        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDLA())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDLA();

            }
            return false;
        }

        public static clsLocal_DLA GetLocalDLAByID(int ID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsLocal_DLA_Data.GetLocalDLAByID(ID, ref ApplicationID, ref LicenseClassID))
            {
                return new clsLocal_DLA(ID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }

        }

        public static enApplicationStatus GetLocalDLA_Status(int ID)
        {

            return (enApplicationStatus)Convert.ToByte(clsLocal_DLA_Data.GetLocalDLA_Status(ID));

        }


        public static DataTable GetAllLocal_DLA()
        {
            return clsLocal_DLA_Data.GetAllLocalDLA();
        }

        public static DataTable GetAllLocal_DLA_ByID(int ID)
        {
            return clsLocal_DLA_Data.GetLocalDLA_ByID(ID);
        }

        public static DataTable GetAllLocal_DLA_ByFulllName(string FullName)
        {
            return clsLocal_DLA_Data.GetLocalDLA_ByFullName(FullName);
        }

        public static DataTable GetAllLocal_DLA_ByStatus(string Status)
        {
            return clsLocal_DLA_Data.GetLocalDLA_ByStatus(Status);
        }
        public static DataTable GetAllLocal_DLA_ByNationalNb(string NationalNb)
        {

            return clsLocal_DLA_Data.GetLocalDLA_BynationalNb(NationalNb);
        }

        public static bool IsLicenseClassExist_ForPerson(string NationalNumber , string LicenseClassName)
        {
            return clsLocal_DLA_Data.IsLicenseClassExist(NationalNumber,LicenseClassName);
        }

        public static bool DeleteLocalDLA(int ID)
        {
          if(clsLocal_DLA_Data.CheckLocalDLAIntegrity(ID))
            {
                return false;
            }
            else
            {
                return clsLocal_DLA_Data.DeleteLocalDLA(ID);
            }
        }

        public static int GetLocalDLA_PassedTests(int ID)
        {
            return clsLocal_DLA_Data.GetLocalDLA_PassedTests(ID);
        }

        public static int GetLocalDLA_FailedTests(int ID)
        {
            return clsLocal_DLA_Data.GetLocalDLA_FailedTests(ID);
        }
    }
}
