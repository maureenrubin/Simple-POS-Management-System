using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsApp.DATA_ACCESS;
using WindowsApp.MODEL;

namespace WindowsApp.FORMS
{
    public partial class EmployeeForm : Form
    {

        private EmployeeDBContext DbContext;
        public EmployeeForm()
        {
            InitializeComponent();
            DbContext = new EmployeeDBContext();
        }

        private void EmployeeForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDB.tb_Staff' table. You can move, or remove it, as needed.
            this.tb_StaffTableAdapter.Fill(this.employeeDB.tb_Staff);

        }

        private void btnAddEmployee_Click(object sender, System.EventArgs e)
        {
            using (EDITemployeeForm employeeEditForm = new EDITemployeeForm())
            {
                if (employeeEditForm.ShowDialog () == DialogResult.OK)
                
                {
                    AddEmployeeToDataGridView(employeeEditForm.Employee);
                }
            }
        }

        private void AddEmployeeToDataGridView(EmployeeModel employee)
        {
            
            // Add a new row and get its index
            int rowIndex = dataGridEmployee.Rows.Add();

            // Fill the new row with the employee data
            dataGridEmployee.Rows[rowIndex].Cells["ID"].Value = employee.employeeID;
            dataGridEmployee.Rows[rowIndex].Cells["FIRST NAME"].Value = employee.fname;
            dataGridEmployee.Rows[rowIndex].Cells["LAST NAME"].Value = employee.lname;
            dataGridEmployee.Rows[rowIndex].Cells["USERNAME"].Value = employee.username;
            dataGridEmployee.Rows[rowIndex].Cells["PASSWORD"].Value = employee.password;
            dataGridEmployee.Rows[rowIndex].Cells["CONTACT"].Value = employee.contact;
            dataGridEmployee.Rows[rowIndex].Cells["POSITION"].Value = employee.position;


        }
    }
}
