using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class ProductUserControl : UserControl
    {
        // Declare the Click event with the associated ProductModel
        public event EventHandler<ProductModel> ProductEditClicked, ProductDeleted;
        private ProductModel product;
        public event EventHandler AddtoCartClicked;
       
        public ProductUserControl()
        {
            InitializeComponent();
            this.Click += OnControlClick;
            lbl_ProductName.Click += OnControlClick;
            lbl_ProductPrice.Click += OnControlClick;
            pb_ProductImage.Click += OnControlClick;
           

        }
      
        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (sender == DeleteButton) // Assuming there's a delete button
            {
                ProductDeleted?.Invoke(this, product);
            }
            else
            {
                ProductEditClicked?.Invoke(this, product);
            }

        }
       

        // Set the associated product data and populate the control
        public void SetProductData(ProductModel product)
        {
            this.product = product;
            name = product.ProductName;
            price = product.ProductPrice;
            image = product.ProductImage;
        }
        private void OnControlClick(object sender, EventArgs e)
        {// Trigger the ProductClicked event and pass the associated product
            ProductEditClicked?.Invoke(this, product);

            // Trigger the AddtoCartClicked event and pass the associated product
            AddtoCartClicked?.Invoke(this, EventArgs.Empty);
        }
      
      

        #region Properties

        private string pName;
        private decimal productPrice;
        private byte[] productImage;

        [Category("Custom Props")]
        public string name
        {
            get { return pName; }
            set
            {
                pName = value;
                lbl_ProductName.Text = value;
            }
        }

        [Category("Custom Props")]
        public decimal price
        {
            get { return productPrice; }
            set
            {
                productPrice = value;
                lbl_ProductPrice.Text = string.Format("₱{0:N2}", productPrice);
            }
        }

        

        [Category("Custom Props")]
        public byte[] image
        {
            get { return productImage; }
            set
            {
                productImage = value;
                if (productImage != null && productImage.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(productImage))
                    {
                        pb_ProductImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_ProductImage.Image = null;
                }
            }
        }

      

        // Property to control the visibility of the delete button AT THE MAIN PANEL
        [Category("Custom Props")]
        public bool ShowDeleteButton
        {
            get { return DeleteButton.Visible; }
            set { DeleteButton.Visible = value; }
        }

        #endregion
    }
}
