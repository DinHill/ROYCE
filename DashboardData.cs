using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DesktopInformationSystem
{
    // DataDashboard class handles data retrieval from the database for persons, teachers, admins, and students
    public class DataDashboard
    {
        private readonly string _connectionString = ConfigConnect.connection; // Connection string for the database

        // Method to get all persons with optional filter condition
        public List<Person> GetPersonData(string filterCondition = "")
        {
            List<Person> personDataList = new List<Person>();

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open(); // Open the database connection
                    string sql = "SELECT PersonID, Name, Telephone, Email, Role FROM Person";

                    if (!string.IsNullOrEmpty(filterCondition))
                    {
                        sql += " WHERE " + filterCondition; // Apply filter if provided
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Person person = new Person
                                {
                                    PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Telephone = reader.IsDBNull(reader.GetOrdinal("Telephone")) ? null : reader.GetString(reader.GetOrdinal("Telephone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Role = reader.GetString(reader.GetOrdinal("Role"))
                                };

                                personDataList.Add(person); // Add person to the list
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to Database: " + ex.Message); // Log errors
                }
            }

            return personDataList; // Return the list of persons
        }

        // Method to get detailed data for a specific teacher
        public Teacher GetTeacherData(int personId)
        {
            Teacher teacher = null;

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open(); // Open the database connection
                    string sql = "SELECT t.TeacherID, p.PersonID, p.Name, p.Telephone, p.Email, p.Role, t.Salary, t.Subject1, t.Subject2 " +
                                 "FROM Teachers t " +
                                 "JOIN Person p ON t.PersonID = p.PersonID " +
                                 "WHERE p.PersonID = @PersonID";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personId); // Add parameter for PersonID

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                teacher = new Teacher
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
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to Database: " + ex.Message); // Log errors
                }
            }

            return teacher; // Return the teacher object
        }

        // Method to get detailed data for a specific admin
        public Admin GetAdminData(int personId)
        {
            Admin admin = null;

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open(); // Open the database connection
                    string sql = "SELECT a.AdminID, p.PersonID, p.Name, p.Telephone, p.Email, p.Role, a.Salary, a.EmploymentType, a.WorkingHours " +
                                 "FROM Admins a " +
                                 "JOIN Person p ON a.PersonID = p.PersonID " +
                                 "WHERE p.PersonID = @PersonID";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personId); // Add parameter for PersonID

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                admin = new Admin
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
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to Database: " + ex.Message); // Log errors
                }
            }

            return admin; // Return the admin object
        }

        // Method to get detailed data for a specific student
        public Student GetStudentData(int personId)
        {
            Student student = null;

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open(); // Open the database connection
                    string sql = "SELECT s.StudentID, p.PersonID, p.Name, p.Telephone, p.Email, p.Role, s.CurrentSubject1, s.CurrentSubject2, s.PreviousSubject1, s.PreviousSubject2 " +
                                 "FROM Students s " +
                                 "JOIN Person p ON s.PersonID = p.PersonID " +
                                 "WHERE p.PersonID = @PersonID";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personId); // Add parameter for PersonID

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                student = new Student
                                {
                                    StudentID = reader.GetInt32(reader.GetOrdinal("StudentID")),
                                    PersonID = reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Telephone = reader.IsDBNull(reader.GetOrdinal("Telephone")) ? null : reader.GetString(reader.GetOrdinal("Telephone")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Role = reader.GetString(reader.GetOrdinal("Role")),
                                    CurrentSubject1 = reader.GetString(reader.GetOrdinal("CurrentSubject1")),
                                    CurrentSubject2 = reader.GetString(reader.GetOrdinal("CurrentSubject2")),
                                    PreviousSubject1 = reader.GetString(reader.GetOrdinal("PreviousSubject1")),
                                    PreviousSubject2 = reader.GetString(reader.GetOrdinal("PreviousSubject2"))
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to Database: " + ex.Message); // Log errors
                }
            }

            return student; // Return the student object
        }
    }
}
