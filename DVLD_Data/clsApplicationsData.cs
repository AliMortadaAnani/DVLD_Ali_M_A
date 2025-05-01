using DVLD_General;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data
{
   public class clsApplicationsData
    {   
        
        public static bool GetApplicationByID(int ID, ref int ApplicantPersonID,
            ref DateTime ApplicationDate, ref int ApplicationTypeID,
            ref enApplicationStatus ApplicationStatus, ref DateTime LastStatusDate,
            ref byte PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Applications WHERE ApplicationID = @ID";

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

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (enApplicationStatus)Convert.ToByte(reader["ApplicationStatus"]);
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (byte)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];



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



        public static int AddNewApplication(int ApplicantPersonID,
          DateTime ApplicationDate, int ApplicationTypeID,
          enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
          byte PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications 
                            (ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                            ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                            VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID,
                            @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", (byte)ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
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


            return ApplicationID;
        }


        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
            enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
            byte PaidFees, int CreatedByUserID)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Applications 
                            SET ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus,
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID
                            WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", (byte)ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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

    }
}
