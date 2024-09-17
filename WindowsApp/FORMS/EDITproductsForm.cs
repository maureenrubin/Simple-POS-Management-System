using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsApp.DATA_ACCESS;
using WindowsApp.FORMS;

namespace WindowsApp.CRUDFORMS.PRODUCTEDITFORM
{
    public partial class EDITproductsForm : Form
    {
        private byte[] productImage;
        private ProductModel product;
        private ProductDBContext dbContext;
       
        
        public EDITproductsForm()
        {
            InitializeComponent();
            dbContext = new ProductDBContext();

        }
        // Constructor for editing an existing product
        public EDITproductsForm(ProductModel product)
        {
            InitializeComponent();
            dbContext = new ProductDBContext();

            if (product != null)
            {
                this.product = product;
                
                // Populate form fields with product data
                txtProductName.Text = product.ProductName;
                txt_ProductPrice.Text = product.ProductPrice.ToString();
                productImage = product.ProductImage;

                // Load image into PictureBox if available
                if (productImage != null)
                {
                    using (MemoryStream ms = new MemoryStream(productImage))
                    {
                        pic_ProductImage.Image = Image.FromStream(ms);
                    }
                }
            }
        }


        private void SaveProductBTN_Click_2(object sender, EventArgs e)
        {

            if (ValidateProductForm())
            {

                if (product == null)
                {
                    // Create a new ProductModel object if adding a new product
                    product = new ProductModel();
                }
                // Update product object with data from the form
                product.ProductName = txtProductName.Text;
                product.ProductPrice = decimal.Parse(txt_ProductPrice.Text);
                product.ProductImage = productImage;

                // Add or update the product in the database
                if (product.ProductID == 0)
                {
                    dbContext.AddProduct(product);
                }
                else
                {
                    dbContext.UpdateProduct(product);
                }
                // Close the form with OK result
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //SAVE BUTTON 
      
        private bool ValidateProductForm()
        {
            // Check if all required fields are filled
            return !string.IsNullOrWhiteSpace(txtProductName.Text) &&
                   !string.IsNullOrWhiteSpace(txt_ProductPrice.Text);
        }

        private void CancelBTN_Click_1(object sender, EventArgs e)
        {
            // Close the form without saving changes
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
      

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image into the PictureBox
                        pic_ProductImage.Image = Image.FromFile(openFileDialog.FileName);

                        // Convert the image to byte array
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pic_ProductImage.Image.Save(ms, pic_ProductImage.Image.RawFormat);
                            productImage = ms.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txt_ProductPrice.Clear();

            pic_ProductImage.Image = null;
            productImage = null;
            product = null;
        }

       
       
    }
}
   