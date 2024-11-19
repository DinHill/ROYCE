using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    // DashboardForm class manages the main user interface for displaying and filtering data
    public partial class DashboardForm : UserControl
    {
        private DataDashboard dataDashboard; // Instance of DataDashboard for handling data operations

        // Constructor initializes the form and loads data with default filter
        public DashboardForm()
        {
            InitializeComponent(); // Initialize form components
            dataDashboard = new DataDashboard(); // Initialize dataDashboard instance
            LoadData("All"); // Load all data initially
        }

        // Loads data based on the specified filter and updates the DataGridViews
        private void LoadData(string filter)
        {
            string filterCondition = string.Empty;

            // Determine filter condition based on the selected filter
            switch (filter)
            {
                case "Admin":
                    filterCondition = "Role = 'Admin'";
                    break;
                case "Teacher":
                    filterCondition = "Role = 'Teacher'";
                    break;
                case "Student":
                    filterCondition = "Role = 'Student'";
                    break;
                default:
                    filterCondition = string.Empty; // No filter applied
                    break;
            }

            // Retrieve person data and update the DataGridView for all data
            List<Person> personData = dataDashboard.GetPersonData(filterCondition);
            alldata_gridview.DataSource = personData;
            invidata_gridview.DataSource = null; // Clear the detailed view
        }

        // Handles the cell click event in the alldata_gridview DataGridView
        private void alldata_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int personId = (int)alldata_gridview.Rows[e.RowIndex].Cells["PersonID"].Value;
                string role = alldata_gridview.Rows[e.RowIndex].Cells["Role"].Value.ToString();

                object detailedData = null;

                // Retrieve detailed data based on the role
                if (role == "Admin")
                {
                    detailedData = dataDashboard.GetAdminData(personId);
                }
                else if (role == "Teacher")
                {
                    detailedData = dataDashboard.GetTeacherData(personId);
                }
                else if (role == "Student")
                {
                    detailedData = dataDashboard.GetStudentData(personId);
                }

                // Display detailed data in the invidata_gridview DataGridView
                if (detailedData != null)
                {
                    invidata_gridview.DataSource = new List<object> { detailedData };
                    CustomizeDataGridViewColumns(role); // Customize columns based on the role
                }
            }
        }

        // Customizes the columns in invidata_gridview based on the role
        private void CustomizeDataGridViewColumns(string role)
        {
            if (role == "Admin")
            {
                // Set column headers, visibility, and display order for Admin role
                invidata_gridview.Columns["AdminID"].HeaderText = "ID";
                invidata_gridview.Columns["PersonID"].Visible = false;
                invidata_gridview.Columns["AdminID"].DisplayIndex = 0;
                invidata_gridview.Columns["Name"].DisplayIndex = 1;
                invidata_gridview.Columns["Role"].DisplayIndex = 2;
                invidata_gridview.Columns["Telephone"].DisplayIndex = 3;
                invidata_gridview.Columns["Email"].DisplayIndex = 4;
                invidata_gridview.Columns["Salary"].DisplayIndex = 5;
                invidata_gridview.Columns["EmploymentType"].DisplayIndex = 6;
                invidata_gridview.Columns["WorkingHours"].DisplayIndex = 7;
            }
            else if (role == "Teacher")
            {
                // Set column headers, visibility, and display order for Teacher role
                invidata_gridview.Columns["TeacherID"].HeaderText = "ID";
                invidata_gridview.Columns["PersonID"].Visible = false;
                invidata_gridview.Columns["TeacherID"].DisplayIndex = 0;
                invidata_gridview.Columns["Name"].DisplayIndex = 1;
                invidata_gridview.Columns["Role"].DisplayIndex = 2;
                invidata_gridview.Columns["Telephone"].DisplayIndex = 3;
                invidata_gridview.Columns["Email"].DisplayIndex = 4;
                invidata_gridview.Columns["Salary"].DisplayIndex = 5;
                invidata_gridview.Columns["Subject1"].DisplayIndex = 6;
                invidata_gridview.Columns["Subject2"].DisplayIndex = 7;
            }
            else if (role == "Student")
            {
                // Set column headers, visibility, and display order for Student role
                invidata_gridview.Columns["StudentID"].HeaderText = "ID";
                invidata_gridview.Columns["PersonID"].Visible = false;
                invidata_gridview.Columns["StudentID"].DisplayIndex = 0;
                invidata_gridview.Columns["Name"].DisplayIndex = 1;
                invidata_gridview.Columns["Role"].DisplayIndex = 2;
                invidata_gridview.Columns["Telephone"].DisplayIndex = 3;
                invidata_gridview.Columns["Email"].DisplayIndex = 4;
                invidata_gridview.Columns["CurrentSubject1"].DisplayIndex = 5;
                invidata_gridview.Columns["CurrentSubject2"].DisplayIndex = 6;
                invidata_gridview.Columns["PreviousSubject1"].DisplayIndex = 7;
                invidata_gridview.Columns["PreviousSubject2"].DisplayIndex = 8;
            }
        }

        // Handles the cell click event in the invidata_gridview DataGridView
        private void invidata_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any additional actions if needed
        }

        // Handles the click event for the exit button
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        public void ReloadData()
        {
            LoadData("All"); // Reload all data or apply the current filter if needed
        }

    }
}
