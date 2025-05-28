using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace DVLD_Data
{
    public class clsDetainedLicensesData
    {
        public static int AddLicense(int LicenseID,
            DateTime DetainDate, decimal FineFees,
            int CreatedByUserID,bool IsReleased,
             DateTime ReleaseDate,
              int ReleasedByUserID, int ReleaseApplicationID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses 
                            (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, 
                             ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                            VALUES 
                            (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased,
                             @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);


            

            if (ReleaseDate != DateTime.MinValue)  // assuming ReleaseDate is nullable
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);

            if (ReleasedByUserID != -1)  // assuming ReleasedByUserID is nullable
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);

            if (ReleaseApplicationID != -1)  // assuming ReleaseApplicationID is nullable
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);




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

        public static bool GetLicenseByID(int ID, ref int LicenseID,
                        ref DateTime DetainDate, ref decimal FineFees,
                        ref int CreatedByUserID, ref bool IsReleased,
                        ref DateTime ReleaseDate,
                        ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses" +
                " where DetainedLicenses.DetainID = @ID";

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

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = reader["ReleaseDate"] == DBNull.Value
    ? DateTime.MinValue
    : (DateTime)reader["ReleaseDate"];

                    ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value
                        ? -1
                        : (int)reader["ReleasedByUserID"];

                    ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value
                        ? -1
                        : (int)reader["ReleaseApplicationID"];




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
        public static bool GetDetainedLicenseByLicenseID(int LicenseID, ref int DetainID,
                       ref DateTime DetainDate, ref decimal FineFees,
                       ref int CreatedByUserID, ref bool IsReleased,
                       ref DateTime ReleaseDate,
                       ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses" +
                " where DetainedLicenses.LicenseID = @ID and IsReleased = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = reader["ReleaseDate"] == DBNull.Value
    ? DateTime.MinValue
    : (DateTime)reader["ReleaseDate"];

                    ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value
                        ? -1
                        : (int)reader["ReleasedByUserID"];

                    ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value
                        ? -1
                        : (int)reader["ReleaseApplicationID"];




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
        public static bool UpdateLicense(int ID, int LicenseID,
                                DateTime DetainDate, decimal FineFees,
                                int CreatedByUserID, bool IsReleased,
                                DateTime ReleaseDate,
                                int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE DetainedLicenses 
                    SET LicenseID = @LicenseID,
                        DetainDate = @DetainDate,
                        FineFees = @FineFees,
                        CreatedByUserID = @CreatedByUserID,
                        IsReleased = @IsReleased,
                        ReleaseDate = @ReleaseDate,
                        ReleasedByUserID = @ReleasedByUserID,
                        ReleaseApplicationID = @ReleaseApplicationID
                    WHERE DetainID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            // Add parameters
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            // Handle nullable/conditional fields
            if (ReleaseDate != DateTime.MinValue)
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                command.Parameters.AddWithValue("@ReleaseDate", System.DBNull.Value);

            if (ReleasedByUserID != -1)
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", System.DBNull.Value);

            if (ReleaseApplicationID != -1)
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", System.DBNull.Value);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log error if needed
                // Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool ReleaseDetainLicense(int LicenseID, bool Release)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE DetainedLicenses 
                                SET 
                                    isReleased = @IsActive
                            
                                WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IsActive", Release);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicensesView";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                dt = null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static DataTable GetAllDetainedLicensesByNatNB(string NationalNb)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicensesView WHERE NationalNb  LIKE '%' + @Contains + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contains", NationalNb);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                dt = null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetAllDetainedLicensesById(int ID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicensesView WHERE DetainID  LIKE '%' + @Contains + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contains", ID.ToString());
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                dt = null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAllDetainedLicensesByLicenseId(int LicID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicensesView WHERE LicenseID  LIKE '%' + @Contains + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contains", LicID.ToString());
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                dt = null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetAllDetainedLicensesByIsReleased(bool release)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicensesView WHERE IsReleased =@Contains";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contains", release);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                dt = null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
}
