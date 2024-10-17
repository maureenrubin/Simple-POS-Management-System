using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace WindowsApp.DB
{
    //class for login Db so that we can use this datas to create a method for authetication process
    public class LoginDBContext
    {
        //connection string of your db source path so that we can call this out in our authentication method
        private string connectionString = @"Data Source=DJOKERZ\SQLEXPRESS;Initial Catalog=NewApp;Integrated Security=True";


        //Authentication Method
        public bool LoginAccess(string username, string password, out string role)
        {
            role = string.Empty;
            
            try
            {
                bool isAuthenticated = false;

                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   
                    conn.Open();


                    string queryAdmin = "SELECT role FROM AdminAccount WHERE username = @username AND password = @password AND IsActive = 1";
                    
                    SqlCommand cmdAdmin = new SqlCommand(queryAdmin, conn);
                    cmdAdmin.Parameters.AddWithValue("@username", username);
                    cmdAdmin.Parameters.AddWithValue("@password", password);

                    object resultAdmin = cmdAdmin.ExecuteScalar();
                   
                    if(resultAdmin != null)
                    {
                        role = resultAdmin.ToString();
                        isAuthenticated = true;
                    }
                    else
                    {
                        string queryStaff = "SELECT 'Cashier' AS role FROM Staff WHERE username = @username AND password = @password";

                        SqlCommand cmdStaff = new SqlCommand(queryStaff, conn);
                        cmdStaff.Parameters.AddWithValue("@username", username);
                        cmdStaff.Parameters.AddWithValue("@password", password);

                        object resultStaff = cmdStaff.ExecuteScalar();

                        if (resultStaff != null)
                        {
                            role = "Cashier";
                            isAuthenticated = true;
                        }
                    }
                }
                
                return isAuthenticated;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool RequestPasswordReset(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string resetToken = Guid.NewGuid().ToString();
                    DateTime resetExpiry = DateTime.Now.AddHours(24);

                    // Check if the username exists in AdminAccount
                    string queryCheckAdmin = "SELECT COUNT(1) FROM AdminAccount WHERE username = @username";
                    SqlCommand cmdCheckAdmin = new SqlCommand(queryCheckAdmin, conn);
                    cmdCheckAdmin.Parameters.AddWithValue("@username", username);

                    int isAdmin = Convert.ToInt32(cmdCheckAdmin.ExecuteScalar());
                    if (isAdmin > 0)
                    {
                        // Update reset token and expiry in AdminAccount
                        string query = "UPDATE AdminAccount SET ResetToken = @ResetToken, ResetTokenExpiry = @ResetExpiry WHERE username = @username";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ResetToken", resetToken);
                        cmd.Parameters.AddWithValue("@ResetExpiry", resetExpiry);
                        cmd.Parameters.AddWithValue("@username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    else
                    {
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        // Method to Validate Reset Token
        public bool ValidateResetToken(string username, string resetToken)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string queryAdmin = "SELECT COUNT(1) FROM AdminAccount WHERE username = @username AND ResetToken = @ResetToken AND ResetTokenExpiry > @CurrentDate";
                    SqlCommand cmdAdmin = new SqlCommand(queryAdmin, conn);
                    cmdAdmin.Parameters.AddWithValue("@username", username);
                    cmdAdmin.Parameters.AddWithValue("@ResetToken", resetToken);
                    cmdAdmin.Parameters.AddWithValue("@CurrentDate", DateTime.Now);

                    int isTokenValid = Convert.ToInt32(cmdAdmin.ExecuteScalar());
                    return isTokenValid > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool ResetPassword(string username, string newPassword, string resetToken)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Validate the reset token before proceeding
                    if (!ValidateResetToken(username, resetToken))
                    {
                        MessageBox.Show("Invalid or expired reset token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Update the password and clear the reset token in AdminAccount
                    string query = "UPDATE AdminAccount SET password = @NewPassword, ResetToken = NULL, ResetTokenExpiry = NULL WHERE username = @username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    cmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    

       
    }

}

