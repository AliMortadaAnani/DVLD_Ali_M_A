using DVLD_General;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data
{
    public class clsLocal_DLA_Data
    {
        public static bool GetLocalDLAByID(int ID, ref int ApplicationID,
             ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LocalDrivingLicenseApplications" +
                " WHERE LocalDrivingLicenseApplicationID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];

                    LicenseClassID = (int)reader["LicenseClassID"];



                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

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



        public static int AddNewLocalDLA(int ApplicationID,
           int LicenseClassID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications 
                            (ApplicationID, LicenseClassID)
                            VALUES (@ApplicationID, @LicenseClassID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


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


        public static bool UpdateLocalDLA_LicenseClass(int ID, int ApplicationID, int LicenseClassID)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE LocalDrivingLicenseApplications 
                            SET LicenseClassID = @LicenseClassID,
                                
                            WHERE LocalDrivingLicenseApplicationID = @ID AND ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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


        public static int GetLocalDLA_Status(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Status FROM LocalApplicationStatusView2" +
    " WHERE Local_DLA_ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            int Status = 0;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int status))
                {
                    Status = status;
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

            return Status;
        }


        public static bool UpdateLocalDLA_Status(int ID,enApplicationStatus Status)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update A set A.ApplicationStatus = @Status
                from Applications A
                join LocalDrivingLicenseApplications l on l.ApplicationID=A.ApplicationID
                where l.LocalDrivingLicenseApplicationID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Status", (byte)Status);

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



        public static DataTable GetAllLocalDLA()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LocalDLA_ExtendedView";

            SqlCommand command = new SqlCommand(query, connection);

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
    }
}
