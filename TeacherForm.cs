using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesktopInformationSystem
{
    public partial class TeacherForm : UserControl
    {
        public TeacherForm()
        {
            InitializeComponent();
            DisplayTeacherData(); // Load teacher data on initialization
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // Any additional initialization code can go here
        }

        // Event handler for adding a teacher
        private void addteacher_button_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm the addition
            DialogResult result = MessageBox.Show("Are you sure you want to add this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Create Teacher object from form data
                    Teacher teacher = new Teacher
                    {
                        Name = teacher_name.Text.Trim(),
                        Email = teacher_email.Text.Trim(),
                        Telephone = teacher_telephone.Text.Trim(),
                        Salary = decimal.Parse(teacher_salary.Text.Trim()),
                        Subject1 = teacher_subject1.Text.Trim(),
                        Subject2 = teacher_subject2.Text.Trim()
                    };

                    // Add teacher to the database
                    TeacherData teacherData = new TeacherData();
                    teacherData.AddTeacher(teacher);

                    MessageBox.Show("Teacher added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTeacherData(); // Refresh teacher data display
                    ClearFields(); // Clear form fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for updating a teacher
        private void updateteacher_button_Click(object sender, EventArgs e)
        {
            // Check if any cells are selected
            if (teacherdata_gridview.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a teacher first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input fields
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm the update
            DialogResult result = MessageBox.Show("Are you sure you want to update this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get the selected cell and row
                    DataGridViewCell selectedCell = teacherdata_gridview.SelectedCells[0];
                    DataGridViewRow selectedRow = teacherdata_gridview.Rows[selectedCell.RowIndex];

                    // Ensure TeacherID column exists and has a valid value
                    if (!teacherdata_gridview.Columns.Contains("TeacherID") ||
                        selectedRow.Cells["TeacherID"].Value == null ||
                        !int.TryParse(selectedRow.Cells["TeacherID"].Value.ToString(), out int teacherID))
                    {
                        MessageBox.Show("Invalid or missing TeacherID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create Teacher object with form data
                    Teacher teacher = new Teacher
                    {
                        Name = teacher_name.Text.Trim(),
                        Email = teacher_email.Text.Trim(),
                        Telephone = teacher_telephone.Text.Trim(),
                        Salary = decimal.Parse(teacher_salary.Text.Trim()),
                        Subject1 = teacher_subject1.Text.Trim(),
                        Subject2 = teacher_subject2.Text.Trim()
                    };

                    // Update teacher in the database
                    TeacherData teacherData = new TeacherData();
                    teacherData.UpdateTeacher(teacherID, teacher);

                    MessageBox.Show("Teacher updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTeacherData(); // Refresh teacher data display
                    ClearFields(); // Clear form fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for deleting a teacher
        private void deleteteacher_button_Click(object sender, EventArgs e)
        {
            // Check if any cells are selected
            if (teacherdata_gridview.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a teacher first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get the selected cell and row
                DataGridViewCell selectedCell = teacherdata_gridview.SelectedCells[0];
                DataGridViewRow selectedRow = teacherdata_gridview.Rows[selectedCell.RowIndex];

                // Ensure TeacherID column exists and has a valid value
                if (!teacherdata_gridview.Columns.Contains("TeacherID") ||
                    selectedRow.Cells["TeacherID"].Value == null ||
                    !int.TryParse(selectedRow.Cells["TeacherID"].Value.ToString(), out int teacherID))
                {
                    MessageBox.Show("Invalid or missing TeacherID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete teacher from the database
                    TeacherData teacherData = new TeacherData();
                    teacherData.DeleteTeacher(teacherID);

                    MessageBox.Show("Teacher deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTeacherData(); // Refresh teacher data display
                    ClearFields(); // Clear form fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears all form fields
        private void ClearFields()
        {
            teacher_name.Text = "";
            teacher_email.Text = "";
            teacher_telephone.Text = "";
            teacher_salary.Text = "";
            teacher_subject1.Text = "";
            teacher_subject2.Text = "";
        }

        // Checks if any input fields are empty
        private bool AreFieldsEmpty()
        {
            return string.IsNullOrEmpty(teacher_name.Text) ||
                   string.IsNullOrEmpty(teacher_email.Text) ||
                   string.IsNullOrEmpty(teacher_telephone.Text) ||
                   string.IsNullOrEmpty(teacher_salary.Text) ||
                   string.IsNullOrEmpty(teacher_subject1.Text) ||
                   string.IsNullOrEmpty(teacher_subject2.Text);
        }

        // Displays the teacher data in the DataGridView and customizes columns
        private void DisplayTeacherData()
        {
            try
            {
                TeacherData teacherData = new TeacherData();
                var teachers = teacherData.GetAllTeachers();
                teacherdata_gridview.DataSource = teachers;
                CustomizeDataGridViewColumns(); // Customize the columns
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Customizes the DataGridView columns
        private void CustomizeDataGridViewColumns()
        {
            teacherdata_gridview.Columns["TeacherID"].HeaderText = "ID";
            teacherdata_gridview.Columns["PersonID"].HeaderText = "Person ID";
            teacherdata_gridview.Columns["Name"].HeaderText = "Name";
            teacherdata_gridview.Columns["Telephone"].HeaderText = "Telephone";
            teacherdata_gridview.Columns["Email"].HeaderText = "Email";
            teacherdata_gridview.Columns["Role"].HeaderText = "Role";
            teacherdata_gridview.Columns["Salary"].HeaderText = "Salary";
            teacherdata_gridview.Columns["Subject1"].HeaderText = "Subject 1";
            teacherdata_gridview.Columns["Subject2"].HeaderText = "Subject 2";

            teacherdata_gridview.Columns["PersonID"].Visible = false;
            teacherdata_gridview.Columns["Role"].Visible = false;

            // Set column display order
            teacherdata_gridview.Columns["TeacherID"].DisplayIndex = 0;
            teacherdata_gridview.Columns["PersonID"].DisplayIndex = 1;
            teacherdata_gridview.Columns["Name"].DisplayIndex = 2;
            teacherdata_gridview.Columns["Telephone"].DisplayIndex = 3;
            teacherdata_gridview.Columns["Email"].DisplayIndex = 4;
            teacherdata_gridview.Columns["Role"].DisplayIndex = 5;
            teacherdata_gridview.Columns["Salary"].DisplayIndex = 6;
            teacherdata_gridview.Columns["Subject1"].DisplayIndex = 7;
            teacherdata_gridview.Columns["Subject2"].DisplayIndex = 8;
        }

        // Event handler for cell click event
        private void teacherdata_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header or an empty row
            if (e.RowIndex >= 0 && e.RowIndex < teacherdata_gridview.Rows.Count)
            {
                // Retrieve the data from the selected row
                DataGridViewRow selectedRow = teacherdata_gridview.Rows[e.RowIndex];

                // Populate the form fields with the data from the selected row
                teacher_name.Text = selectedRow.Cells["Name"].Value.ToString();
                teacher_email.Text = selectedRow.Cells["Email"].Value.ToString();
                teacher_telephone.Text = selectedRow.Cells["Telephone"].Value.ToString();
                teacher_salary.Text = selectedRow.Cells["Salary"].Value.ToString();
                teacher_subject1.Text = selectedRow.Cells["Subject1"].Value.ToString();
                teacher_subject2.Text = selectedRow.Cells["Subject2"].Value.ToString();
            }
        }

        // Event handler for clearing the teacher data form
        private void clearteacherdata_button_Click(object sender, EventArgs e)
        {
            ClearFields(); // Clear form fields
        }

        // Event handler for exiting the application
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
