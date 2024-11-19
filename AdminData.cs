using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DesktopInformationSystem
{
    public class AdminData
    {
        // Connection string for database access
        private readonly string _connectionString = ConfigConnect.connection;

        // Method to add a new admin (creates a new Person and Admin record)
        public void AddAdmin(Admin admin)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Insert into Person table and retrieve the new PersonID
                    string personSql = "INSERT INTO Person (Name, Telephone, Email, Role) VALUES (@Name, @Telephone, @Email, 'Admin'); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand personCmd = new SqlCommand(personSql, connect))
                    {
                        personCmd.Parameters.AddWithValue("@Name", admin.Name);
                        personCmd.Parameters.AddWithValue("@Telephone", admin.Telephone);
                        personCmd.Parameters.AddWithValue("@Email", admin.Email);
                        int personID = Convert.ToInt32(personCmd.ExecuteScalar());

                        // Insert into Admin table with the retrieved PersonID
                        string adminSql = "INSERT INTO Admins (PersonID, Salary, EmploymentType, WorkingHours) VALUES (@PersonID, @Salary, @EmploymentType, @WorkingHours)";
                        using (SqlCommand adminCmd = new SqlCommand(adminSql, connect))
                        {
                            adminCmd.Parameters.AddWithValue("@PersonID", personID);
                            adminCmd.Parameters.AddWithValue("@Salary", admin.Salary);
                            adminCmd.Parameters.AddWithValue("@EmploymentType", admin.EmploymentType);
                            adminCmd.Parameters.AddWithValue("@WorkingHours", admin.WorkingHours);
                            adminCmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding admin: " + ex.Message);
                }
            }
        }

        // Method to update an existing admin's details
        public void UpdateAdmin(int adminID, Admin admin)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Update the Person table based on the AdminID
                    string personSql = "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = (SELECT PersonID FROM Admins WHERE AdminID = @AdminID)";
                    using (SqlCommand personCmd = new SqlCommand(personSql, connect))
                    {
                        personCmd.Parameters.AddWithValue("@Name", admin.Name);
                        personCmd.Parameters.AddWithValue("@Telephone", admin.Telephone);
                        personCmd.Parameters.AddWithValue("@Email", admin.Email);
                        personCmd.Parameters.AddWithValue("@AdminID", adminID);
                        personCmd.ExecuteNonQuery();
                    }

                    // Update the Admin table
                    string adminSql = "UPDATE Admins SET Salary = @Salary, EmploymentType = @EmploymentType, WorkingHours = @WorkingHours WHERE AdminID = @AdminID";
                    using (SqlCommand adminCmd = new SqlCommand(adminSql, connect))
                    {
                        adminCmd.Parameters.AddWithValue("@Salary", admin.Salary);
                        adminCmd.Parameters.AddWithValue("@EmploymentType", admin.EmploymentType);
                        adminCmd.Parameters.AddWithValue("@WorkingHours", admin.WorkingHours);
                        adminCmd.Parameters.AddWithValue("@AdminID", adminID);
                        adminCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating admin: " + ex.Message);
                }
            }
        }

        // Method to delete an admin (removes records from both Person and Admin tables)
        public void DeleteAdmin(int adminID)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Retrieve PersonID before deleting from Admins
                    string getPersonIdSql = "SELECT PersonID FROM Admins WHERE AdminID = @AdminID";
                    using (SqlCommand getPersonIdCmd = new SqlCommand(getPersonIdSql, connect))
                    {
                        getPersonIdCmd.Parameters.AddWithValue("@AdminID", adminID);
                        int personID = Convert.ToInt32(getPersonIdCmd.ExecuteScalar());

                        // Delete from Admin table
                        string adminSql = "DELETE FROM Admins WHERE AdminID = @AdminID";
                        using (SqlCommand adminCmd = new SqlCommand(adminSql, connect))
                        {
                            adminCmd.Parameters.AddWithValue("@AdminID", adminID);
                            adminCmd.ExecuteNonQuery();
                        }

                        // Delete from Person table
                        string personSql = "DELETE FROM Person WHERE PersonID = @PersonID";
                        using (SqlCommand personCmd = new SqlCommand(personSql, connect))
                        {
                            personCmd.Parameters.AddWithValue("@PersonID", personID);
                            personCmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting admin: " + ex.Message);
                }
            }
        }

        // Method to retrieve a list of all admins
        public List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Query to get all admins with their details
                    string sql = "SELECT a.AdminID, p.PersonID, p.Name, p.Telephone, p.Email, p.Role, a.Salary, a.EmploymentType, a.WorkingHours " +
                                 "FROM Admins a INNER JOIN Person p ON a.PersonID = p.PersonID";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Admin admin = new Admin
                                {
                                    AdminID = reader.GetInt32(reader.GetOrdinal("AdminID")),
                                    PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Telephone = reader.IsDBNull(reader.GetOrdinal("Telephone")) ? null : reader.GetString(reader.GetOrdinal("Telephone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Role = reader.GetString(reader.GetOrdinal("Role")),
                                    Salary = reader.GetDecimal(reader.GetOrdinal("Salary")),
                                    EmploymentType = reader.GetString(reader.GetOrdinal("EmploymentType")),
                                    WorkingHours = reader.GetInt32(reader.GetOrdinal("WorkingHours"))
                                };
                                admins.Add(admin);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving admins: " + ex.Message);
                }
            }
            return admins;
        }
    }
}
