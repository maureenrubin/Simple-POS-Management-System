using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp.FORMS
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            dashboard_panel.Visible = true;
        }

        public void LoadForm(object Form)
        {
            if (this.dashboard_panel.Controls.Count > 0)
                this.dashboard_panel.Controls.Clear();
            
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dashboard_panel.Controls.Add(f);
            this.dashboard_panel.Tag = f;
            f.Show();
        }
        //CLOSE BUTTON
        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // PRODUCT BUTTON
        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new Productform());
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        //CUSTOMERS BUTTON
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            //Transition
            EmployeeTime.Start();
            //Load Form
            LoadForm(new EmployeeForm());
        }

        //TRANSACTION BUTTON
        private void TransactionBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new TransactionForm());
        }

        //ABOUT BUTTON
       
        private void POSBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new MainForm());
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            LoadForm(new HomeDash());
        }



        //TRANSITIONS
        bool customerExpand = false;

        private void customerTimer_Tick(object sender, EventArgs e)
        {
            if (customerExpand == false)
            {
                customerContainer.Height += 10;
                if (customerContainer.Height >= 112)
                {

                    EmployeeTime.Stop();
                    customerExpand = true;
                }
            }
            else
            {
                customerContainer.Height -= 10;
                if (customerContainer.Height <= 51)
                {
                    EmployeeTime.Stop();
                    customerExpand = false;
                }
            }
        } 

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        { if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 68)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                   
                } 

            }else
            {
                sidebar.Width += 10;    
                if (sidebar.Width >= 293)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    
                }


            }

        }


      

       
    }
}
