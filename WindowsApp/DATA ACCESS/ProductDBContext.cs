using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;



namespace WindowsApp.DATA_ACCESS
{
    public class ProductDBContext
    {
        
        private string connectionString = @"Data Source=DJOKERZ\SQLEXPRESS;Initial Catalog=NewApp;Integrated Security=True";
       

        public List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            string query = "SELECT ProductID, ProductName, ProductPrice, ProductImage " +
                "FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductModel product = new ProductModel
                    {
                        ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                        ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                        ProductPrice = reader.GetDecimal(reader.GetOrdinal("ProductPrice")),
                        ProductImage = reader["ProductImage"] as byte[] ?? null
                    };

                    products.Add(product);
                }

                reader.Close();
            }

            return products;
        }

        public void AddProduct(ProductModel product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand
                    ("INSERT INTO Products (ProductName, ProductPrice, ProductImage) " +
                     "VALUES (@ProductName, @ProductPrice, @ProductImage)", connection))
                    {

                        // Uses SqlDataReader to read data from the database and maps it to ProductModel instances.
                        command.Parameters.AddWithValue("@ProductName", product.ProductName);
                        command.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                        command.Parameters.AddWithValue("@ProductImage", (object)product.ProductImage ?? DBNull.Value);



                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Product {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateProduct(ProductModel product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand comd = new SqlCommand
                        ("UPDATE Products " + "SET ProductName = @ProductName, ProductPrice = @ProductPrice, ProductImage = @ProductImage " +
                        "WHERE ProductID = @ProductID", connection))
                    {
                        comd.Parameters.AddWithValue("@ProductID", product.ProductID);
                        comd.Parameters.AddWithValue("@ProductName", product.ProductName);
                        comd.Parameters.AddWithValue("@Productprice", product.ProductPrice);
                        comd.Parameters.AddWithValue("@ProductImage",product.ProductImage);

                        comd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating Product{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void DeleteProduct(int productID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM Products WHERE ProductID = @ProductID", connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
