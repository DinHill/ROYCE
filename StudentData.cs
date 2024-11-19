using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DesktopInformationSystem
{
    public class StudentData
    {
        // Connection string for the database
        private readonly string _connectionString = ConfigConnect.connection;

        // Method to add a new student (creates a new Person and Student)
        public void AddStudent(Student student)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Insert into Person table and get the newly created PersonID
                    string personSql = "INSERT INTO Person (Name, Telephone, Email, Role) VALUES (@Name, @Telephone, @Email, 'Student'); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand personCmd = new SqlCommand(personSql, connect))
                    {
                        personCmd.Parameters.AddWithValue("@Name", student.Name);
                        personCmd.Parameters.AddWithValue("@Telephone", student.Telephone);
                        personCmd.Parameters.AddWithValue("@Email", student.Email);
                        int personID = Convert.ToInt32(personCmd.ExecuteScalar());

                        // Insert into Students table
                        string studentSql = "INSERT INTO Students (PersonID, CurrentSubject1, CurrentSubject2, PreviousSubject1, PreviousSubject2) VALUES (@PersonID, @CurrentSubject1, @CurrentSubject2, @PreviousSubject1, @PreviousSubject2)";
                        using (SqlCommand studentCmd = new SqlCommand(studentSql, connect))
                        {
                            studentCmd.Parameters.AddWithValue("@PersonID", personID);
                            studentCmd.Parameters.AddWithValue("@CurrentSubject1", student.CurrentSubject1);
                            studentCmd.Parameters.AddWithValue("@CurrentSubject2", student.CurrentSubject2);
                            studentCmd.Parameters.AddWithValue("@PreviousSubject1", student.PreviousSubject1);
                            studentCmd.Parameters.AddWithValue("@PreviousSubject2", student.PreviousSubject2);

                            int rowsAffected = studentCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Student added to Students table successfully.");
                            }
                            else
                            {
                                Console.WriteLine("No rows affected when adding student to Students table.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding student: " + ex.Message);
                }
            }
        }

        // Method to update an existing student
        public void UpdateStudent(int studentID, Student student)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Update the Person table
                    string personSql = "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = (SELECT PersonID FROM Students WHERE StudentID = @StudentID)";
                    using (SqlCommand personCmd = new SqlCommand(personSql, connect))
                    {
                        personCmd.Parameters.AddWithValue("@Name", student.Name);
                        personCmd.Parameters.AddWithValue("@Telephone", student.Telephone);
                        personCmd.Parameters.AddWithValue("@Email", student.Email);
                        personCmd.Parameters.AddWithValue("@StudentID", studentID);
                        personCmd.ExecuteNonQuery();
                    }

                    // Update the Student table
                    string studentSql = "UPDATE Students SET CurrentSubject1 = @CurrentSubject1, CurrentSubject2 = @CurrentSubject2, PreviousSubject1 = @PreviousSubject1, PreviousSubject2 = @PreviousSubject2 WHERE StudentID = @StudentID";
                    using (SqlCommand studentCmd = new SqlCommand(studentSql, connect))
                    {
                        studentCmd.Parameters.AddWithValue("@CurrentSubject1", student.CurrentSubject1);
                        studentCmd.Parameters.AddWithValue("@CurrentSubject2", student.CurrentSubject2);
                        studentCmd.Parameters.AddWithValue("@PreviousSubject1", student.PreviousSubject1);
                        studentCmd.Parameters.AddWithValue("@PreviousSubject2", student.PreviousSubject2);
                        studentCmd.Parameters.AddWithValue("@StudentID", studentID);
                        studentCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating student: " + ex.Message);
                }
            }
        }

        // Method to delete a student (deletes from both Person and Student tables)
        public void DeleteStudent(int studentID)
        {
            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // Get the PersonID before deleting the Student
                    string getPersonIdSql = "SELECT PersonID FROM Students WHERE StudentID = @StudentID";
                    using (SqlCommand getPersonIdCmd = new SqlCommand(getPersonIdSql, connect))
                    {
                        getPersonIdCmd.Parameters.AddWithValue("@StudentID", studentID);
                        int personID = Convert.ToInt32(getPersonIdCmd.ExecuteScalar());

                        // Delete from Student table
                        string studentSql = "DELETE FROM Students WHERE StudentID = @StudentID";
                        using (SqlCommand studentCmd = new SqlCommand(studentSql, connect))
                        {
                            studentCmd.Parameters.AddWithValue("@StudentID", studentID);
                            studentCmd.ExecuteNonQuery();
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
                    Console.WriteLine("Error deleting student: " + ex.Message);
                }
            }
        }

        // Method to get all students
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connect = new SqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();

                    // SQL query to retrieve student details
                    string sql = "SELECT s.StudentID, p.PersonID, p.Name, p.Telephone, p.Email, p.Role, s.CurrentSubject1, s.CurrentSubject2, s.PreviousSubject1, s.PreviousSubject2 " +
                                 "FROM Students s INNER JOIN Person p ON s.PersonID = p.PersonID";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Read each row and create Student objects
                            while (reader.Read())
                            {
                                Student student = new Student
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
                                students.Add(student); // Add student to the list
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving students: " + ex.Message);
                }
            }
            return students; // Return the list of students
        }
    }
}
