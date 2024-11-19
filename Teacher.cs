using System;

namespace DesktopInformationSystem
{
    // Represents a teacher in the system
    public class Teacher : Person
    {
        // Unique identifier for the teacher
        public int TeacherID { get; set; }

        // Salary of the teacher
        public decimal Salary { get; set; }

        // Primary subject taught by the teacher
        public string Subject1 { get; set; }

        // Secondary subject taught by the teacher
        public string Subject2 { get; set; }

        // Returns a formatted string displaying teacher details
        public string DisplayTeacherInfo()
        {
            return $"Teacher ID: {TeacherID}\n" +
                   $"Name: {Name}\n" +
                   $"Email: {Email}\n" +
                   $"Telephone: {Telephone}\n" +
                   $"Salary: {Salary:C}\n" + // Format salary as currency
                   $"Subjects: {Subject1}, {Subject2}\n"; // Lists the subjects taught
        }
    }
}
