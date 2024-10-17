using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WindowsApp.MODEL;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsApp.DATA_ACCESS
{
    public class EmployeeDBContext
    {
        private string connectionString = @"Data Source=DJOKERZ\SQLEXPRESS;Initial Catalog=NewApp;Integrated Security=True";

        
        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
           
            string query = "SELECT employeeID, fname, lname, username, password, contact, position FROM Staff";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeModel employeeModel = new EmployeeModel
                    {
                        employeeID = reader.GetInt32(reader.GetOrdinal("employeeID")),
                        fname = reader.GetString(reader.GetOrdinal("fname")),
                        lname = reader.GetString(reader.GetOrdinal("lname")),
                        username = reader.GetString(reader.GetOrdinal("username")),
                        password = reader.GetString(reader.GetOrdinal("password")),
                        contact = reader.GetString(reader.GetOrdinal("Contact")),
                        position = reader.GetString(reader.GetOrdinal("position"))


                    };

                    employees.Add(employeeModel);
                }
                reader.Close();
            }
            return employees;
        }


        public void AddEmployees(EmployeeModel employee)
        {
          try
          {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                    
                    // Corrected SQL INSERT command with proper formatting and commas
              using (SqlCommand cmd = new SqlCommand("INSERT INTO Staff (fname, lname, username, password, contact, position) " +
                                                           "VALUES (@fname, @lname, @username, @password, @contact, @position)", connection))
              {
                 
                 cmd.Parameters.AddWithValue("@fname", employee.fname);
                 cmd.Parameters.AddWithValue("@lname", employee.lname);
                 cmd.Parameters.AddWithValue("@username", employee.username);
                 cmd.Parameters.AddWithValue("@password", employee.password);
                 cmd.Parameters.AddWithValue("@contact", employee.contact);
                 cmd.Parameters.AddWithValue("@position", employee.position);

                cmd.ExecuteNonQuery();
              }

            }
  
          } 
            catch (Exception ex)
          {
                MessageBox.Show($"Error Adding Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand
                          ("UPDATE Staff SET fname = @fname, lname = @lname, username = @username, password = @password, contact = @contact, position = @position " +
                           "WHERE employeeID = @employeeID", conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", employee.fname);
                        cmd.Parameters.AddWithValue("@lname", employee.lname);
                        cmd.Parameters.AddWithValue("@username", employee.username);
                        cmd.Parameters.AddWithValue("@password", employee.password);
                        cmd.Parameters.AddWithValue("@contact", employee.contact);
                        cmd.Parameters.AddWithValue("@position", employee.position);
                        cmd.Parameters.AddWithValue("@employeeID", employee.employeeID);

                        cmd.ExecuteNonQuery();
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteEmployee(int employeeID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    using (SqlCommand cmd = new SqlCommand ("DELETE FROM Staff WHERE employeeID = @employeeID", conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        cmd.ExecuteNonQuery();
                    }


                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Dajam's Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }  
}        

