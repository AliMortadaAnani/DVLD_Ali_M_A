using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
   public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public clsTest()
        {
            ID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private clsTest(int id, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            ID = id;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }
        private bool _AddNewTest()
        {
            this.ID = clsTestData.AddTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return (this.ID != -1);
        }

        public  bool Save()

        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
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

        public static bool DeleteTest(int ID)
        {
            return clsTestData.DeleteTest(ID);
        }
    }
}
