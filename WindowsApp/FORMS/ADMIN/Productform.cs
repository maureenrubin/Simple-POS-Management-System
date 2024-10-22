﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsApp.CRUDFORMS.PRODUCTEDITFORM;
using WindowsApp.DATA_ACCESS;

namespace WindowsApp.FORMS
{
    public partial class Productform : Form
    {
        private ProductDBContext dbContext;

        public Productform()
        {
            InitializeComponent();
            dbContext = new ProductDBContext();


            DisplayProductsToFlowLayoutProduct();
         

        }

        //NO REFERENCE
        private void ConfigureControlsBasedOnRole(string userRole)
        {
            if (userRole == "Manager")
            {
                // Manager has access to all controls
                ProAddBtn.Enabled = true;

            }
            else if (userRole == "Cashier")
            {
                // Cashier only has access to certain controls
                ProAddBtn.Enabled = false;
            }
        }

        public void DisplayProductsToFlowLayoutProduct()
        {
            // Clear existing controls in the FlowLayoutPanel
            flowLayoutProduct.Controls.Clear();

            // Fetch products from the database
            List<ProductModel> products = dbContext.GetProducts();

            foreach (ProductModel product in products)
            {
                // Create and populate the UserControl
                ProductUserControl productControl = new ProductUserControl();
                productControl.SetProductData(product);

                //ProductClicked is for editing products
                productControl.ProductEditClicked += ProductControl_ProductEditClicked;
                productControl.ProductDeleted += ProductControl_ProductDeleted;

                // Add the UserControl to the FlowLayoutPanel
                flowLayoutProduct.Controls.Add(productControl);

             
            }
        }


        //DELETE PRODUCT IN PRODUCT CONTROL
        private void ProductControl_ProductDeleted(object sender, ProductModel product)
        {
            // Confirm before deleting
            Console.WriteLine("ProductControl_ProductDeleted called"); // Debug statement

            if (product != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {product.ProductName}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbContext.DeleteProduct(product.ProductID);
                        DisplayProductsToFlowLayoutProduct();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ProductControl_ProductEditClicked(object sender, ProductModel product)
        {
            using (EDITproductsForm productCrudForm = new EDITproductsForm(product))
            {
                if (productCrudForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayProductsToFlowLayoutProduct();
                }
            }
        }



        private void ProAddBtn_Click(object sender, EventArgs e)
        {
            // Step 1: Open the ProductCrud form as a dialog
            using (EDITproductsForm productEditForm = new EDITproductsForm())
            {
                // Show the form as a dialog 
                if (productEditForm.ShowDialog() == DialogResult.OK)
                {
                    // updates or refreshing the flow layout panel after adding a product
                    DisplayProductsToFlowLayoutProduct();
                }
            }
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            DisplayProductsToFlowLayoutProduct();
        }


        //NO REFERENCE
        private void SearchBOX_TextChanged_1(object sender, EventArgs e)
        {

            string searchQuery = Search.Text.Trim().ToLower();

            // Filter products based on the search query
            List<ProductModel> filteredProducts = dbContext.GetProducts()
                .Where(p => p.ProductName.ToLower().Contains(searchQuery)).ToList();

            // Clear and re-display products in the FlowLayoutPanel
            flowLayoutProduct.Controls.Clear();

            foreach (ProductModel product in filteredProducts)
            {
                ProductUserControl productControl = new ProductUserControl
                {
                    name = product.ProductName,
                    price = product.ProductPrice,
                    image = product.ProductImage,
                    ShowDeleteButton = false // Hide delete button in MainForm
                };
               
                flowLayoutProduct.Controls.Add(productControl);


            }
        }
    }
}
