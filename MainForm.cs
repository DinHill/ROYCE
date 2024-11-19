using DesktopInformationSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    // MainForm class manages the main application window and handles navigation between different forms
    public partial class MainForm : Form
    {
        // Constructor initializes the form and sets the default visible form
        public MainForm()
        {
            InitializeComponent(); // Initialize form components
            dasboardForm1.Visible = true; // Show the Dashboard form by default
        }

        // Handles the click event for the Dashboard button
        private void dashboard_button_Click(object sender, EventArgs e)
        {
            // Show the Dashboard form and hide others
            dasboardForm1.Visible = true;
            dasboardForm1.ReloadData();
            adminForm1.Visible = false;
            studentForm1.Visible = false;
            teacherForm1.Visible = false;
        }

        // Handles the click event for the Admin button
        private void admin_button_Click(object sender, EventArgs e)
        {
            // Show the Admin form and hide others
            dasboardForm1.Visible = false;
            adminForm1.Visible = true;
            studentForm1.Visible = false;
            teacherForm1.Visible = false;
        }

        // Handles the click event for the Teacher button
        private void teacher_button_Click(object sender, EventArgs e)
        {
            // Show the Teacher form and hide others
            dasboardForm1.Visible = false;
            adminForm1.Visible = false;
            studentForm1.Visible = false;
            teacherForm1.Visible = true;
        }

        // Handles the click event for the Student button
        private void student_button_Click(object sender, EventArgs e)
        {
            // Show the Student form and hide others
            dasboardForm1.Visible = false;
            adminForm1.Visible = false;
            studentForm1.Visible = true;
            teacherForm1.Visible = false;
        }
    }
}
