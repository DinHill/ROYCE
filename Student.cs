using System;

namespace DesktopInformationSystem
{
    // Represents a student in the system
    public class Student : Person
    {
        // Unique identifier for the student
        public int StudentID { get; set; }

        // Current subject the student is enrolled in
        public string CurrentSubject1 { get; set; }

        // Second current subject the student is enrolled in
        public string CurrentSubject2 { get; set; }

        // Previous subject the student was enrolled in
        public string PreviousSubject1 { get; set; }

        // Second previous subject the student was enrolled in
        public string PreviousSubject2 { get; set; }

        // Returns a formatted string displaying student details
        public string DisplayStudentInfo()
        {
            return $"Student ID: {StudentID}\n" +
                   $"Name: {Name}\n" + // Student's name
                   $"Email: {Email}\n" + // Student's email address
                   $"Telephone: {Telephone}\n" + // Student's telephone number
                   $"Current Subjects: {CurrentSubject1}, {CurrentSubject2}\n" + // List of current subjects
                   $"Previous Subjects: {PreviousSubject1}, {PreviousSubject2}\n"; // List of previous subjects
        }
    }
}
