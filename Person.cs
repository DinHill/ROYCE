using System;

namespace DesktopInformationSystem
{
    // Represents a person in the system
    public class Person
    {
        // Unique identifier for the person
        public int PersonID { get; set; }

        // Name of the person
        public string Name { get; set; }

        // Telephone number of the person
        public string Telephone { get; set; }

        // Email address of the person
        public string Email { get; set; }

        // Role of the person (e.g., Admin, Teacher, Student)
        public string Role { get; set; }

        // Displays the person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Telephone: {Telephone}, Email: {Email}, Role: {Role}");
        }
    }
}
