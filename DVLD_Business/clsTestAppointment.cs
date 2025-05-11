using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data;
using DVLD_General;
namespace DVLD_Business
{
   public  class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }

        public int TestTypeID { get; set; }

        public int LocalDrivingLicenseApplicationID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public decimal PaidFees { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsLocked { get; set; }

        public int RetakeTestApplicationID { get; set; }


        public clsTestAppointment()
        {
            ID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;
        }

        private clsTestAppointment(int iD, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            
            ID = iD;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeTestApplicationID = retakeTestApplicationID;

            Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            this.ID = clsTestAppointmentsData.AddTestAppointment(TestTypeID,LocalDrivingLicenseApplicationID,
                AppointmentDate,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID);
            return (this.ID != -1);
        }

        public static clsTestAppointment GetTestAppointmentByID(int ID)
        {
            int TestTypeID = -1, LocalDrivingLicenseApplicationID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = false;

            if (clsTestAppointmentsData.FindTestAppointment(ID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointment(ID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate,
                    PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsTestAppointmentByTestTypeExist_NotLocked(int LocalDLA_ID, int TestTypeID)
        {
            return clsTestAppointmentsData.IsTestAppointmentByTestTypeExist(LocalDLA_ID, TestTypeID);
        }   
        
        public static DataTable GetAllTestAppointmentsByTestTypeAndLocal_DLA_ID(int ID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetAllTestAppointmentsByTestTypeAndLocalID(ID, TestTypeID);
        }   

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsData.UpdateTestAppointment_Date(ID,AppointmentDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:
                    return _UpdateTestAppointment();


            }
            return false;
        }


        public static  bool LockTestAppointment(int ID)
        {
            return clsTestAppointmentsData.LockTestAppointment(ID);
        }

        public static int GetFailedTestsByTestTypeForLocalDLA(int LocalDLAID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetFailedTestsByTestTypeForLocalDLA(LocalDLAID, TestTypeID);
        }

        public static int GetPassedTestsByTestTypeForLocalDLA(int LocalDLAID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetPassedTestsByTestTypeForLocalDLA(LocalDLAID, TestTypeID);
        }

        public static bool DeleteTestAppointment(int ID)
        {
            if(clsTestAppointmentsData.CheckTestAppointmentIntegrity(ID))
            {
                return false;
            }
            else
            { return clsTestAppointmentsData.DeleteTestAppointment(ID); }
        }

        public static bool UpdateRetakeTestApp_Status(int RetakeTestAppID, enApplicationStatus status)
        {
            return clsTestAppointmentsData.UpdateRetakeTestApp_Status(RetakeTestAppID, status);
        }

    }
}
