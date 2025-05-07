using DVLD_General;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data
{
    public class clsTestAppointmentsData
    {
        public static int AddTestAppointment(int TestTypeID,int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate,decimal PaidFees,int CreatedByUserID,
            bool IsLocked,int RetakeTestApplicationID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments 
                            (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, 
                             CreatedByUserID, IsLocked, RetakeTestApplicationID)
                            VALUES 
                            (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees,
                             @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID.ToString() != "")
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", System.DBNull.Value);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ID;
        }

        public static bool IsTestAppointmentByTestTypeExist(int ID,int TestTypeID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from TestAppointments t where t.LocalDrivingLicenseApplicationID = @ID\r\nand IsLocked = 0 and TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static DataTable GetAllTestAppointmentsByTestTypeAndID(int ID,int TestTypeID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select t.TestAppointmentID, t.AppointmentDate,t.PaidFees,t.IsLocked\r\nfrom TestAppointments t\r\nwhere t.TestTypeID = @TestTypeID And t.LocalDrivingLicenseApplicationID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool UpdateTestAppointment_Date(int ID, DateTime Date)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update t set t.AppointmentDate = @Date"+
                " from TestAppointments t where t.testappointmentId = @ID ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Date", Date);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isUpdated = true;
                }
                else
                {
                    isUpdated = false;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isUpdated = false;
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }

        public static bool LockTestAppointment(int ID)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update t set t.IsLocked = 1" +
                " from TestAppointments t where t.testappointmentId = @ID ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
         

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isUpdated = true;
                }
                else
                {
                    isUpdated = false;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isUpdated = false;
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }

        public static int GetFailedTestsByTestTypeForLocalDLA(int LocalDLAID,int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select FailedTests_ByType = count(TestResult) from tests t\r\njoin TestAppointments ta on t.TestAppointmentID = ta.TestAppointmentID\r\nwhere ta.LocalDrivingLicenseApplicationID =  @ID\r\nand ta.TestTypeID = @TestTypeID and TestResult = 0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", LocalDLAID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            int failedtests = 0;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int failed))
                {
                    failedtests = failed;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return failedtests;
        }

        public static int GetPassedTestsByTestTypeForLocalDLA(int LocalDLAID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select PassedTests_ByType = count(TestResult) from tests t\r\njoin TestAppointments ta on t.TestAppointmentID = ta.TestAppointmentID\r\nwhere ta.LocalDrivingLicenseApplicationID =  @ID\r\nand ta.TestTypeID = @TestTypeID and TestResult = 1";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", LocalDLAID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            int failedtests = 0;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int failed))
                {
                    failedtests = failed;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return failedtests;
        }


        public static bool DeleteTestAppointment(int ID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                result = (rowsAffected > 0);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                result = false;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static bool CheckTestAppointmentIntegrity(int ID)
        {
            bool isLinked = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select top 1 found = 1 
            from tests t where t.TestAppointmentID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isLinked = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isLinked = false;
            }
            finally
            {
                connection.Close();
            }
            return isLinked;
        }
    }
}
