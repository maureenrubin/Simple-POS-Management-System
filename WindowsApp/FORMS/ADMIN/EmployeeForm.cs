using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsApp.DATA_ACCESS;
using WindowsApp.MODEL;
using System.Data;
using System.Collections.Generic;
using System;
using System.Linq;

namespace WindowsApp.FORMS
{
    public partial class EmployeeForm : Form
    {

        private EmployeeDBContext employeeDbContext;
        private EmployeeModel selectedEmployee;

        public EmployeeForm()
        {
            InitializeComponent();
            employeeDbContext = new EmployeeDBContext();
            selectedEmployee = new EmployeeModel();
        }
     
        private void LoadEmployeeDataToDataGridView()
        {
            List<EmployeeModel> employees = employeeDbContext.GetEmployees();

            DataTable employeeTable = staff._Staff;
           
            employeeTable.Rows.Clear();

            foreach (var employee in employees)
            {
                DataRow row = employeeTable.NewRow();
                row["employeeID"] = employee.employeeID;
                row["fname"] = employee.fname;
                row["lname"] = employee.lname;
                row["username"] = employee.username;
                row["password"] = employee.password;
                row["contact"] = employee.contact;
                row["position"] = employee.position;
              
                employeeTable.Rows.Add(row);


            }

            EmployeeDatGridView.DataSource = employeeTable;
        }


        private void EmployeeForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'staff._Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staff._Staff);
            LoadEmployeeDataToDataGridView();
        }

       

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (EDITemployeeForm employeeEditForm = new EDITemployeeForm())
            {
                if (employeeEditForm.ShowDialog() == DialogResult.OK)

                {
                    employeeDbContext.AddEmployees(employeeEditForm.Employee);
                   
                    LoadEmployeeDataToDataGridView();
                }
            }
        }


        private void EditBtnEmployee_Click(object sender, EventArgs e)
        {
            if(selectedEmployee != null)
            {
                using (EDITemployeeForm employeeEditForm = new EDITemployeeForm(selectedEmployee))
                {
                    if(employeeEditForm.ShowDialog() == DialogResult.OK)
                    {
                        employeeDbContext.UpdateEmployee(employeeEditForm.Employee);

                        LoadEmployeeDataToDataGridView();
                    }
                }
            }else
            {
                MessageBox.Show("Please select an employee to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)

        {

            if (selectedEmployee != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedEmployee.fname}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    employeeDbContext.DeleteEmployee(selectedEmployee.employeeID);

                    LoadEmployeeDataToDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeDatGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                int selectedEmployeeID = Convert.ToInt32(EmployeeDatGridView.Rows[e.RowIndex].Cells["employeeIDDataGridViewTextBoxColumn"].Value);

                selectedEmployee = employeeDbContext.GetEmployees().FirstOrDefault(emp => emp.employeeID == selectedEmployeeID);
               

                if (selectedEmployee != null)
                    {
                        using (EDITemployeeForm employeeEditForm = new EDITemployeeForm(selectedEmployee))
                        {
                            if (employeeEditForm.ShowDialog() == DialogResult.OK)
                            {
                                employeeDbContext.UpdateEmployee(employeeEditForm.Employee);

                                LoadEmployeeDataToDataGridView();
                            }
                        }
                    }
                else
                {
                        MessageBox.Show("Please select an employee to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
