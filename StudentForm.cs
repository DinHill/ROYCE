using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    public partial class StudentForm : UserControl
    {
        public StudentForm()
        {
            InitializeComponent();
            DisplayStudentData(); // Load student data on initialization
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Any additional initialization code can go here
        }

        // Event handler for adding a student
        private void add_button_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm the addition
            DialogResult result = MessageBox.Show("Are you sure you want to add this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Create Student object from form data
                    Student student = new Student
                    {
                        Name = student_name.Text.Trim(),
                        Email = student_email.Text.Trim(),
                        Telephone = student_telephone.Text.Trim(),
                        CurrentSubject1 = student_cs1.Text.Trim(),
                        CurrentSubject2 = student_cs2.Text.Trim(),
                        PreviousSubject1 = student_pss1.Text.Trim(),
                        PreviousSubject2 = student_pss2.Text.Trim()
                    };

                    // Add student to the database
                    StudentData studentData = new StudentData();
                    studentData.AddStudent(student);

                    MessageBox.Show("Student added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayStudentData(); // Refresh student data display
                    ClearFields(); // Clear form fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for updating a student
        private void update_button_Click(object sender, EventArgs e)
        {
            // Check if any cells are selected
            if (studentdata_gridview.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a student first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input fields
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm the update
            DialogResult result = MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get the selected cell and row
                    DataGridViewCell selectedCell = studentdata_gridview.SelectedCells[0];
                    DataGridViewRow selectedRow = studentdata_gridview.Rows[selectedCell.RowIndex];

                    // Ensure StudentID column exists and has a valid value
                    if (!studentdata_gridview.Columns.Contains("StudentID") ||
                        selectedRow.Cells["StudentID"].Value == null ||
                        !int.TryParse(selectedRow.Cells["StudentID"].Value.ToString(), out int studentID))
                    {
                        MessageBox.Show("Invalid or missing StudentID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create Student object with form data
                    Student student = new Student
                    {
                        Name = student_name.Text.Trim(),
                        Email = student_email.Text.Trim(),
                        Telephone = student_telephone.Text.Trim(),
                        CurrentSubject1 = student_cs1.Text.Trim(),
                        CurrentSubject2 = student_cs2.Text.Trim(),
                        PreviousSubject1 = student_pss1.Text.Trim(),
                        PreviousSubject2 = student_pss2.Text.Trim()
                    };

                    // Update student in the database
                    StudentData studentData = new StudentData();
                    studentData.UpdateStudent(studentID, student);

                    MessageBox.Show("Student updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayStudentData(); // Refresh student data display
                    ClearFields(); // Clear form fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for deleting a student
        private void delete_button_Click(object sender, EventArgs e)
        {
            // Check if any cells are selected
            if (studentdata_gridview.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a student first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get the selected cell and row
                DataGridViewCell selectedCell = studentdata_gridview.SelectedCells[0];
                DataGridViewRow selectedRow = studentdata_gridview.Rows[selectedCell.RowIndex];

                // Ensure StudentID column exists and has a valid value
                if (!studentdata_gridview.Columns.Contains("StudentID") ||
                    selectedRow.Cells["StudentID"].Value == null ||
                    !int.TryParse(selectedRow.Cells["StudentID"].Value.ToString(), out int studentID))
                {
                    MessageBox.Show("Invalid or missing StudentID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete student from the database
                    StudentData studentData = new StudentData();
                    studentData.DeleteStudent(studentID);

                    MessageBox.Show("Student deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayStudentData(); // Refresh student data display
                    ClearFields(); // Clear form fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears all form fields
        private void ClearFields()
        {
            student_name.Text = "";
            student_email.Text = "";
            student_telephone.Text = "";
            student_cs1.Text = "";
            student_cs2.Text = "";
            student_pss1.Text = "";
            student_pss2.Text = "";
        }

        // Checks if any input fields are empty
        private bool AreFieldsEmpty()
        {
            return string.IsNullOrEmpty(student_name.Text) ||
                   string.IsNullOrEmpty(student_email.Text) ||
                   string.IsNullOrEmpty(student_telephone.Text) ||
                   string.IsNullOrEmpty(student_cs1.Text) ||
                   string.IsNullOrEmpty(student_cs2.Text) ||
                   string.IsNullOrEmpty(student_pss1.Text) ||
                   string.IsNullOrEmpty(student_pss2.Text);
        }

        // Displays the student data in the DataGridView and customizes columns
        private void DisplayStudentData()
        {
            try
            {
                StudentData studentData = new StudentData();
                var students = studentData.GetAllStudents();
                studentdata_gridview.DataSource = students;
                CustomizeDataGridViewColumns(); // Customize the columns
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Customizes the DataGridView columns
        private void CustomizeDataGridViewColumns()
        {
            studentdata_gridview.Columns["StudentID"].HeaderText = "ID";
            studentdata_gridview.Columns["PersonID"].HeaderText = "Person ID";
            studentdata_gridview.Columns["Name"].HeaderText = "Name";
            studentdata_gridview.Columns["Telephone"].HeaderText = "Telephone";
            studentdata_gridview.Columns["Email"].HeaderText = "Email";
            studentdata_gridview.Columns["Role"].HeaderText = "Role";
            studentdata_gridview.Columns["CurrentSubject1"].HeaderText = "Current Subject 1";
            studentdata_gridview.Columns["CurrentSubject2"].HeaderText = "Current Subject 2";
            studentdata_gridview.Columns["PreviousSubject1"].HeaderText = "Previous Subject 1";
            studentdata_gridview.Columns["PreviousSubject2"].HeaderText = "Previous Subject 2";

            studentdata_gridview.Columns["PersonID"].Visible = false;
            studentdata_gridview.Columns["Role"].Visible = false;

            // Set column display order
            studentdata_gridview.Columns["StudentID"].DisplayIndex = 0;
            studentdata_gridview.Columns["PersonID"].DisplayIndex = 1;
            studentdata_gridview.Columns["Name"].DisplayIndex = 2;
            studentdata_gridview.Columns["Telephone"].DisplayIndex = 3;
            studentdata_gridview.Columns["Email"].DisplayIndex = 4;
            studentdata_gridview.Columns["Role"].DisplayIndex = 5;
            studentdata_gridview.Columns["CurrentSubject1"].DisplayIndex = 6;
            studentdata_gridview.Columns["CurrentSubject2"].DisplayIndex = 7;
            studentdata_gridview.Columns["PreviousSubject1"].DisplayIndex = 8;
            studentdata_gridview.Columns["PreviousSubject2"].DisplayIndex = 9;
        }

        // Event handler for cell click event
        private void studentdata_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header or an empty row
            if (e.RowIndex >= 0 && e.RowIndex < studentdata_gridview.Rows.Count)
            {
                // Retrieve the data from the selected row
                DataGridViewRow selectedRow = studentdata_gridview.Rows[e.RowIndex];

                // Populate the form fields with the data from the selected row
                student_name.Text = selectedRow.Cells["Name"].Value.ToString();
                student_email.Text = selectedRow.Cells["Email"].Value.ToString();
                student_telephone.Text = selectedRow.Cells["Telephone"].Value.ToString();
                student_cs1.Text = selectedRow.Cells["CurrentSubject1"].Value.ToString();
                student_cs2.Text = selectedRow.Cells["CurrentSubject2"].Value.ToString();
                student_pss1.Text = selectedRow.Cells["PreviousSubject1"].Value.ToString();
                student_pss2.Text = selectedRow.Cells["PreviousSubject2"].Value.ToString();
            }
        }

        // Event handler for clearing the student data form
        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearFields(); // Clear form fields
        }

        private void StudentForm_Load_1(object sender, EventArgs e)
        {
            // This load event handler is not used. Consider removing it if unnecessary.
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
