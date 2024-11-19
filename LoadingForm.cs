using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopInformationSystem
{
    // LoadingForm class represents the initial loading screen of the application
    public partial class LoadingForm : Form
    {
        // Constructor for the LoadingForm
        public LoadingForm()
        {
            InitializeComponent(); // Initializes form components
        }

        // Handles the timer's tick event
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the width of the loading panel
            panel2.Width += 6;

            // Check if the loading panel is fully expanded
            if (panel2.Width > 800)
            {
                timer1.Stop(); // Stop the timer

                // Show the SignInForm and hide the loading form
                SignInForm signInForm = new SignInForm();
                signInForm.Show();
                this.Hide();
            }
        }

        // Placeholder for actions when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Placeholder for actions when the picture box is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
