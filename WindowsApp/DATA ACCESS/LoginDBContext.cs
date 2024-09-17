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
        public bool Verification(string username, string password)
        {
            try
            {
                bool isAuthenticated = false;

                

                //creating a new connection named = "conn" together with the connection string method to connect in our sql
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //opens the "conn" to connect in our sql
                    conn.Open();


                    string query = "SELECT role FROM tb_Accounts WHERE username = @username AND password = password AND IsActive = 1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                  
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                   
                    if(result != null)
                    {
                        isAuthenticated = true;
                    }
                } return isAuthenticated;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string GetUserRole(string username)
        {
            string role = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT role FROM tb_Accounts WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@username", username);

                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    role = result.ToString();
                }
            }
            return role;
        } 

       
    }

}

