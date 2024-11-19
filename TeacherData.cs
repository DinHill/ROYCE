using DesktopInformationSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DesktopInformationSystem
{
    public class TeacherData
    {
        private readonly string _connectionString = ConfigConnect.connection;

        // Method to add a new teacher (creates a new Person and Teacher)
        public void AddTeacher(Teacher teacher)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Insert the teacher's information into the Person table
                    string personSql = "INSERT INTO Person (Name, Telephone, Email, Role) VALUES (@Name, @Telephone, @Email, 'Teacher'); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand personCmd = new SqlCommand(personSql, connect))
                    {
                        personCmd.Parameters.AddWithValue("@Name", teacher.Name);
                        personCmd.Parameters.AddWithValue("@Telephone", teacher.Telephone);
                        personCmd.Parameters.AddWithValue("@Email", teacher.Email);
                        int personID = Convert.ToInt32(personCmd.ExecuteScalar());

                        // Insert the teacher's specific information into the Teachers table
                        string teacherSql = "INSERT INTO Teachers (PersonID, Salary, Subject1, Subject2) VALUES (@PersonID, @Salary, @Subject1, @Subject2)";
                        using (SqlCommand teacherCmd = new SqlCommand(teacherSql, connect))
                        {
                            teacherCmd.Parameters.AddWithValue("@PersonID", personID);
                            teacherCmd.Parameters.AddWithValue("@Salary", teacher.Salary);
                            teacherCmd.Parameters.AddWithValue("@Subject1", teacher.Subject1);
                            teacherCmd.Parameters.AddWithValue("@Subject2", teacher.Subject2);
                            teacherCmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or display error message
                    Console.WriteLine("Error adding teacher: " + ex.Message);
                }
            }
        }

        // Method to update an existing teacher's information
        public void UpdateTeacher(int teacherID, Teacher teacher)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Update the general information in the Person table
                    string personSql = "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = (SELECT PersonID FROM Teachers WHERE TeacherID = @TeacherID)";
                    using (SqlCommand personCmd = new SqlCommand(personSql, connect))
                    {
                        personCmd.Parameters.AddWithValue("@Name", teacher.Name);
                        personCmd.Parameters.AddWithValue("@Telephone", teacher.Telephone);
                        personCmd.Parameters.AddWithValue("@Email", teacher.Email);
                        personCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                        personCmd.ExecuteNonQuery();
                    }

                    // Update the specific information in the Teachers table
                    string teacherSql = "UPDATE Teachers SET Salary = @Salary, Subject1 = @Subject1, Subject2 = @Subject2 WHERE TeacherID = @TeacherID";
                    using (SqlCommand teacherCmd = new SqlCommand(teacherSql, connect))
                    {
                        teacherCmd.Parameters.AddWithValue("@Salary", teacher.Salary);
                        teacherCmd.Parameters.AddWithValue("@Subject1", teacher.Subject1);
                        teacherCmd.Parameters.AddWithValue("@Subject2", teacher.Subject2);
                        teacherCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                        teacherCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Log or display error message
                    Console.WriteLine("Error updating teacher: " + ex.Message);
                }
            }
        }

        // Method to delete a teacher (removes records from both Person and Teacher tables)
        public void DeleteTeacher(int teacherID)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Retrieve the PersonID associated with the TeacherID
                    string getPersonIdSql = "SELECT PersonID FROM Teachers WHERE TeacherID = @TeacherID";
                    using (SqlCommand getPersonIdCmd = new SqlCommand(getPersonIdSql, connect))
                    {
                        getPersonIdCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                        int personID = Convert.ToInt32(getPersonIdCmd.ExecuteScalar());

                        // Delete the teacher record from the Teachers table
                        string teacherSql = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";
                        using (SqlCommand teacherCmd = new SqlCommand(teacherSql, connect))
                        {
                            teacherCmd.Parameters.AddWithValue("@TeacherID", teacherID);
                            teacherCmd.ExecuteNonQuery();
                        }

                        // Delete the associated person record from the Person table
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
                    // Log or display error message
                    Console.WriteLine("Error deleting teacher: " + ex.Message);
                }
            }
        }

        // Method to retrieve all teachers' information
        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Query to select all teachers and their associated person information
                    string sql = "SELECT t.TeacherID, p.PersonID, p.Name, p.Telephone, p.Email, p.Role, t.Salary, t.Subject1, t.Subject2 " +
                                 "FROM Teachers t INNER JOIN Person p ON t.PersonID = p.PersonID";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Read each record and create a Teacher object
                            while (reader.Read())
                            {
                                Teacher teacher = new Teacher
                                {
                                    TeacherID = reader.GetInt32(reader.GetOrdinal("TeacherID")),
                                    PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Telephone = reader.IsDBNull(reader.GetOrdinal("Telephone")) ? null : reader.GetString(reader.GetOrdinal("Telephone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Role = reader.GetString(reader.GetOrdinal("Role")),
                                    Salary = reader.GetDecimal(reader.GetOrdinal("Salary")),
                                    Subject1 = reader.GetString(reader.GetOrdinal("Subject1")),
                                    Subject2 = reader.GetString(reader.GetOrdinal("Subject2"))
                                };
                                teachers.Add(teacher);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or display error message
                    Console.WriteLine("Error retrieving teachers: " + ex.Message);
                }
            }
            return teachers;
        }
    }
}
