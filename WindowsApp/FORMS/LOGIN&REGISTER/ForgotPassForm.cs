using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.DB;

namespace WindowsApp.FORMS
{
    public partial class ForgotPassForm : Form
    {
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void btnCaancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ResetPasswordBTN_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string resetToken = txtResetToken.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(resetToken) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Instantiate the LoginDBContext to call the ResetPassword method
            LoginDBContext loginDbContext = new LoginDBContext();

            bool passwordReset = loginDbContext.ResetPassword(username, newPassword, resetToken);

            if (passwordReset)
            {
                MessageBox.Show("Password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after successful password reset
            }
            else
            {
                MessageBox.Show("Invalid token or the token has expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestResetPassBTN_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Instantiate the LoginDBContext to call the RequestPasswordReset method
            LoginDBContext loginDbContext = new LoginDBContext();

            bool resetRequested = loginDbContext.RequestPasswordReset(username);

            if (resetRequested)
            {
                MessageBox.Show("Password reset request was successful. Please check your email for the reset token.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, open the ResetPasswordForm for token entry here
            }
            else
            {
                MessageBox.Show("Username not found or unable to request a reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheck.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
                txtResetToken.PasswordChar = '\0';// Show the password by setting PasswordChar to null character
            }
            else
            {
                txtResetToken.PasswordChar = '•';
                txtNewPassword.PasswordChar = '•';// Hide the password by setting PasswordChar to a bullet or any character you prefer
            }
        }
    }
}
