using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data;
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

        public bool IsTestAppointmentByTestTypeExist(int ID, int TestTypeID)
        {
            return clsTestAppointmentsData.IsTestAppointmentByTestTypeExist(ID, TestTypeID);
        }   
        
        public static DataTable GetAllTestAppointmentsByTestTypeAndID(int ID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetAllTestAppointmentsByTestTypeAndID(ID, TestTypeID);
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
    }
}
