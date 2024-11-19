using System;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    // SignInForm class handles user authentication and login
    public partial class SignInForm : Form
    {
        // Default credentials for login
        private const string DefaultUsername = "admin";
        private const string DefaultPassword = "123456";

        // Constructor for the SignInForm
        public SignInForm()
        {
            InitializeComponent(); // Initializes form components
        }

        // Handles the click event for the login button
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve and trim the username and password from the text boxes
            string username = username_signin.Text.Trim();
            string password = password_signin.Text.Trim();

            // Validate the credentials against default values
            if (username == DefaultUsername && password == DefaultPassword)
            {
                // If credentials are correct, show the DashboardForm and hide the current form
                MainForm dashboardForm = new MainForm();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                // If credentials are incorrect, display an error message
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles the click event for the exit label
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        // Placeholder for actions when the form loads
        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        // Toggles password visibility based on the checkbox state
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_signin.UseSystemPasswordChar = true; // Show password characters
            }
            else
            {
                password_signin.UseSystemPasswordChar = false; // Hide password characters
            }
        }

        // Placeholder for actions when the username text changes
        private void username_signin_TextChanged(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the password text changes
        private void password_signin_TextChanged(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the second label is clicked
        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the panel is painted
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // Placeholder for actions when the second panel is painted
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        // Placeholder for actions when the picture box is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the fifth label is clicked
        private void label5_Click(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the third label is clicked
        private void label3_Click(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the seventh label is clicked
        private void label7_Click(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the sixth label is clicked
        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
