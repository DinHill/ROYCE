using DesktopInformationSystem;
using System;

namespace DesktopInformationSystem
{
    // Represents an administrative staff member in the system
    public class Admin : Person
    {
        // Unique identifier for the admin
        public int AdminID { get; set; }

        // Salary of the admin
        public decimal Salary { get; set; }

        // Type of employment: Full-time or Part-time
        public string EmploymentType { get; set; }

        // Number of working hours per week
        public int WorkingHours { get; set; }

        // Returns a formatted string displaying admin details
        public string DisplayAdminInfo()
        {
            return $"Admin ID: {AdminID}\n" +
                   $"Name: {Name}\n" +
                   $"Email: {Email}\n" +
                   $"Telephone: {Telephone}\n" +
                   $"Salary: {Salary:C}\n" +
                   $"Employment Type: {EmploymentType}\n" +
                   $"Working Hours: {WorkingHours}\n";
        }
    }
}
