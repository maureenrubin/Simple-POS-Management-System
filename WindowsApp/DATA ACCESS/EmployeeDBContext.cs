﻿using System;
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

        public void AddEmployees(EmployeeModel employee)
        {
          try
          {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                    
                    // Corrected SQL INSERT command with proper formatting and commas
              using (SqlCommand cmd = new SqlCommand("INSERT INTO tb_Staff (fname, lname, username, password, contact, position) " +
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
  
          } catch (Exception ex)
             {
                MessageBox.Show($"Error Adding Employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

      
    }  
}        
