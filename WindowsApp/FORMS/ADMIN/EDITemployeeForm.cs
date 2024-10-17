using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.DATA_ACCESS;
using WindowsApp.MODEL;

namespace WindowsApp.FORMS
{
    public partial class EDITemployeeForm : Form
    {
        private EmployeeDBContext dBContext;
        private EmployeeModel employee;

        public EmployeeModel Employee
        {
            get { return employee; }
        }

        public EDITemployeeForm()
        {
            InitializeComponent();
            dBContext = new EmployeeDBContext();
            employee = new EmployeeModel();
        }
      
        
        public EDITemployeeForm(EmployeeModel employee)
        {
            InitializeComponent();
            dBContext = new EmployeeDBContext();

            if (employee != null)
            {
                this.employee = employee;

                txtFname.Text = employee.fname;
                txtLname.Text = employee.lname;
                txtUsername.Text = employee.username;
                txtPassword.Text = employee.password;
                txtContact.Text = employee.contact;
                txtPosition.Text = employee.position;

            }else
            {
                this.employee = new EmployeeModel();
                
            }
            
        }

        private bool ValidateEmployeeForm()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return !string.IsNullOrWhiteSpace(txtFname.Text) &&
                   !string.IsNullOrWhiteSpace(txtLname.Text) &&
                   !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                   !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (ValidateEmployeeForm())
            {

                employee.fname = txtFname.Text;
                employee.lname = txtLname.Text;
                employee.username = txtUsername.Text;
                employee.password = txtPassword.Text;
                employee.contact = txtContact.Text;
                employee.position = txtPosition.Text;
                
                try
                {
                    if (employee.employeeID == 0)
                    {
                        dBContext.AddEmployees(employee);
                        MessageBox.Show("New employee Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dBContext.UpdateEmployee(employee);
                        MessageBox.Show("Employee Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
           
        }
    }
}
