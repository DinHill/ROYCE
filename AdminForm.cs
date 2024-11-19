using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    public partial class AdminForm : UserControl
    {
        // Constructor to initialize the form and load admin data
        public AdminForm()
        {
            InitializeComponent();
            DisplayAdminData(); // Load admin data on initialization
        }

        // Event handler for form load event
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Any additional initialization code can go here
        }

        // Event handler for updating an admin
        private void updateadmin_button_Click(object sender, EventArgs e)
        {
            // Check if any cells are selected
            if (admindata_gridview.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select an admin first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input fields
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm the update
            DialogResult result = MessageBox.Show("Are you sure you want to update this admin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get the selected cell and row
                    DataGridViewCell selectedCell = admindata_gridview.SelectedCells[0];
                    DataGridViewRow selectedRow = admindata_gridview.Rows[selectedCell.RowIndex];

                    // Ensure AdminID column exists and has a valid value
                    if (!admindata_gridview.Columns.Contains("AdminID") ||
                        selectedRow.Cells["AdminID"].Value == null ||
                        !int.TryParse(selectedRow.Cells["AdminID"].Value.ToString(), out int adminID))
                    {
                        MessageBox.Show("Invalid or missing AdminID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create Admin object with form data
                    Admin admin = new Admin
                    {
                        Name = admin_name.Text.Trim(),
                        Email = admin_email.Text.Trim(),
                        Telephone = admin_telephone.Text.Trim(),
                        Salary = decimal.Parse(admin_salary.Text.Trim()),
                        EmploymentType = employmenttype.Text.Trim(),
                        // Parse WorkingHours as int
                        WorkingHours = int.Parse(workinghours.Text.Trim())
                    };

                    // Update admin in the database
                    AdminData adminData = new AdminData();
                    adminData.UpdateAdmin(adminID, admin);

                    MessageBox.Show("Admin updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAdminData(); // Refresh admin data display
                    ClearFields(); // Clear form fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for deleting an admin
        private void deleteadmin_button_Click(object sender, EventArgs e)
        {
            // Check if any cells are selected
            if (admindata_gridview.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select an admin first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get the selected cell and row
                DataGridViewCell selectedCell = admindata_gridview.SelectedCells[0];
                DataGridViewRow selectedRow = admindata_gridview.Rows[selectedCell.RowIndex];

                // Ensure AdminID column exists and has a valid value
                if (!admindata_gridview.Columns.Contains("AdminID") ||
                    selectedRow.Cells["AdminID"].Value == null ||
                    !int.TryParse(selectedRow.Cells["AdminID"].Value.ToString(), out int adminID))
                {
                    MessageBox.Show("Invalid or missing AdminID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this admin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete admin from the database
                    AdminData adminData = new AdminData();
                    adminData.DeleteAdmin(adminID);

                    MessageBox.Show("Admin deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAdminData(); // Refresh admin data display
                    ClearFields(); // Clear form fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears all form fields
        private void ClearFields()
        {
            admin_name.Text = "";
            admin_email.Text = "";
            admin_telephone.Text = "";
            admin_salary.Text = "";
            employmenttype.Text = "";
            workinghours.Text = "";
        }

        // Checks if any input fields are empty
        private bool AreFieldsEmpty()
        {
            return string.IsNullOrEmpty(admin_name.Text) ||
                   string.IsNullOrEmpty(admin_email.Text) ||
                   string.IsNullOrEmpty(admin_telephone.Text) ||
                   string.IsNullOrEmpty(admin_salary.Text) ||
                   string.IsNullOrEmpty(employmenttype.Text) ||
                   string.IsNullOrEmpty(workinghours.Text);
        }

        // Displays the admin data in the DataGridView and customizes columns
        private void DisplayAdminData()
        {
            try
            {
                AdminData adminData = new AdminData();
                var admins = adminData.GetAllAdmins(); // Retrieve all admins from the database
                admindata_gridview.DataSource = admins; // Bind data to DataGridView
                CustomizeDataGridViewColumns(); // Customize the columns
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying admin data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Customizes the DataGridView columns
        private void CustomizeDataGridViewColumns()
        {
            // Set column headers
            admindata_gridview.Columns["AdminID"].HeaderText = "ID";
            admindata_gridview.Columns["PersonID"].HeaderText = "Person ID";
            admindata_gridview.Columns["Name"].HeaderText = "Name";
            admindata_gridview.Columns["Telephone"].HeaderText = "Telephone";
            admindata_gridview.Columns["Email"].HeaderText = "Email";
            admindata_gridview.Columns["Role"].HeaderText = "Role";
            admindata_gridview.Columns["Salary"].HeaderText = "Salary";
            admindata_gridview.Columns["EmploymentType"].HeaderText = "Employment Type";
            admindata_gridview.Columns["WorkingHours"].HeaderText = "Working Hours";

            // Hide columns that are not needed for display
            admindata_gridview.Columns["PersonID"].Visible = false;
            admindata_gridview.Columns["Role"].Visible = false;

            // Set column display order
            admindata_gridview.Columns["AdminID"].DisplayIndex = 0;
            admindata_gridview.Columns["PersonID"].DisplayIndex = 1;
            admindata_gridview.Columns["Name"].DisplayIndex = 2;
            admindata_gridview.Columns["Telephone"].DisplayIndex = 3;
            admindata_gridview.Columns["Email"].DisplayIndex = 4;
            admindata_gridview.Columns["Role"].DisplayIndex = 5;
            admindata_gridview.Columns["Salary"].DisplayIndex = 6;
            admindata_gridview.Columns["EmploymentType"].DisplayIndex = 7;
            admindata_gridview.Columns["WorkingHours"].DisplayIndex = 8;
        }

        // Event handler for cell click event
        private void admindata_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header or an empty row
            if (e.RowIndex >= 0 && e.RowIndex < admindata_gridview.Rows.Count)
            {
                // Retrieve the data from the selected row
                DataGridViewRow selectedRow = admindata_gridview.Rows[e.RowIndex];

                // Populate the fields with the selected admin's data
                admin_name.Text = selectedRow.Cells["Name"].Value?.ToString();
                admin_email.Text = selectedRow.Cells["Email"].Value?.ToString();
                admin_telephone.Text = selectedRow.Cells["Telephone"].Value?.ToString();
                admin_salary.Text = selectedRow.Cells["Salary"].Value?.ToString();
                employmenttype.Text = selectedRow.Cells["EmploymentType"].Value?.ToString();
                workinghours.Text = selectedRow.Cells["WorkingHours"].Value?.ToString();
            }
        }

        // Event handler for adding a new admin
        private void addtadmin_button_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm the addition
            DialogResult result = MessageBox.Show("Are you sure you want to add this admin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Create Admin object from form data
                    Admin admin = new Admin
                    {
                        Name = admin_name.Text.Trim(),
                        Email = admin_email.Text.Trim(),
                        Telephone = admin_telephone.Text.Trim(),
                        Salary = decimal.Parse(admin_salary.Text.Trim()),
                        EmploymentType = employmenttype.Text.Trim(),
                        // Parse WorkingHours as int
                        WorkingHours = int.Parse(workinghours.Text.Trim())
                    };

                    // Add admin to the database
                    AdminData adminData = new AdminData();
                    adminData.AddAdmin(admin);

                    MessageBox.Show("Admin added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAdminData(); // Refresh admin data display
                    ClearFields(); // Clear form fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for clearing form fields
        private void clearadmindata_button_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Event handler for exiting the application
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
