using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsApp.DB;
using WindowsApp.FORMS.CASHIER;
using WindowsApp.Get_Set;
using WindowsApp.MODEL;
namespace WindowsApp.FORMS
{
    public partial class LoginForm : Form
    {
        //calling out the login db context class to get the connection string in database
        private LoginDBContext db;

        //method for the login db context
        public LoginForm()
        {
            InitializeComponent();
            db = new LoginDBContext();


        }

        //LOGIN BUTTON
        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            
            //setting a variable for text box in username and password to--
            // use it at the db Authentication
            string username = txt_username.Text;
            string password = txt_password.Text;
         
            string userRole;


            //called out the Authentication  from the connection in login Db context to connect in our statement
            if (db.LoginAccess( username, password, out userRole))
            {
                MessageBox.Show($"Login successful! Welcome, {username}");

                if (userRole == "Manager")
                {
                   
                    Form1 f1 = new Form1();
                    f1.Show();
                  
                }
                else if(userRole == "Cashier")
                {
                    
                    CASHIERFirstForm cashierForm = new CASHIERFirstForm();
                    cashierForm.Show();
            
                }
                else
                {
                    // Admin form (if you want to differentiate Admin)
                    MessageBox.Show("You are logged in as Admin.");
                }

                this.Hide();
            }

            else
            {
                MessageBox.Show("Login failed! Please check your username or password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Login_ShowPassword.Checked)
            {
                txt_password.PasswordChar = '\0'; // Show the password by setting PasswordChar to null character
            }
            else
            {
                txt_password.PasswordChar = '•'; // Hide the password by setting PasswordChar to a bullet or any character you prefer
            }
        }
        //EXIT BUTTON
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassForm forgotpass = new ForgotPassForm();
            forgotpass.ShowDialog();
            
        }

        //Register button


    }

}

