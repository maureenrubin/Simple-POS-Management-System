using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;

using System.Windows.Forms;
using WindowsApp.MODEL;

namespace WindowsApp.DATA_ACCESS
{
    public class PurchaseDBContext
    {
        private static string ConnectionString = @"Data Source=DJOKERZ\SQLEXPRESS;Initial Catalog=NewApp;Integrated Security=True";

        public List<PurchaseModel> GetPurchases()
        {
            List<PurchaseModel> purchases = new List<PurchaseModel>();
         string query = "SELECT ProductID, ProductName, Quantity, ProductPrice, Tax, added_date, Total, CPno, PaymentMethod FROM Purchase";

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PurchaseModel item = new PurchaseModel
                        {
                            ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                            ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                            ProductPrice = reader.GetDecimal(reader.GetOrdinal("ProductPrice")),
                            PurchaseID = reader.GetInt32(reader.GetOrdinal("PurchaseID")),
                            Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            Tax = reader.GetDecimal(reader.GetOrdinal("Tax")),
                            Total = reader.GetDecimal(reader.GetOrdinal("Total")), // Ensure this column exists
                            added_date = reader.GetDateTime(reader.GetOrdinal("added_date")),
                            PaymentMethod = reader.GetString(reader.GetOrdinal("PaymentMethod")),
                            CPno = reader.GetString(reader.GetOrdinal("CPno"))
                        };
                        purchases.Add(item);
                    }
                    reader.Close();
                }
            }catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
            return purchases;
        }




        public void SaveCart(List<PurchaseModel> purchaseItems)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    foreach (var purchase in purchaseItems)
                    {
                        using (SqlCommand command = new SqlCommand(
                           "INSERT INTO Purchase (ProductID, ProductName, Quantity, ProductPrice, Tax, added_date, CPno, PaymentMethod, Total) " +
                            "VALUES (@ProductID, @ProductName, @Quantity, @ProductPrice, @Tax, @added_date, @CPno, @PaymentMethod, @Total)", connection))

                        {
                            command.Parameters.AddWithValue("@ProductID", purchase.ProductID);
                            command.Parameters.AddWithValue("@ProductName", purchase.ProductName);
                            command.Parameters.AddWithValue("@Quantity", purchase.Quantity);
                            command.Parameters.AddWithValue("@ProductPrice", purchase.ProductPrice);
                            command.Parameters.AddWithValue("@Tax", purchase.Tax);
                            command.Parameters.AddWithValue("@added_date", purchase.added_date);
                            command.Parameters.AddWithValue("@CPno", string.IsNullOrEmpty(purchase.CPno) ? (object)DBNull.Value : purchase.CPno);
                            command.Parameters.AddWithValue("@PaymentMethod", purchase.PaymentMethod);
                            command.Parameters.AddWithValue("@Total", purchase.Total);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
          
            {
                MessageBox.Show($"Error Saving Purchase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearAllPurchases()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Purchase", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Clearing Purchases: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
