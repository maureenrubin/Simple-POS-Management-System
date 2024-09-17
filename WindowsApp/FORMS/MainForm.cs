using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsApp.DATA_ACCESS;
using WindowsApp.HANDLER;
using WindowsApp.MODEL;
using WindowsApp.PRINT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsApp.FORMS
{
    public partial class MainForm : Form
    {

        private PrintReceiptForm printReceiptForm;
        private PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Bitmap formImage;
    

        private ProductDBContext dbContext;
        private PurchaseHandler purchaseHandler;
        private PurchaseDBContext purchaseDBContext;
        private ImageList productImage;
        

        public MainForm()
        {
            InitializeComponent();
           
            productImage = new ImageList();

            productImage.ImageSize = new Size(50, 50);
            PurchaseListView.SmallImageList = productImage; // Assign it to the ListView

            dbContext = new ProductDBContext();
            purchaseHandler = new PurchaseHandler();
            purchaseDBContext = new PurchaseDBContext();

            printReceiptForm = new PrintReceiptForm();
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;

            DisplayProductsInMainPanel();
            SetupPurchaseListView();
        }


        // sets up the purchase list view to display details 
        private void SetupPurchaseListView()
        {
            PurchaseListView.View = View.Details;
            PurchaseListView.Columns.Add("Product", 200);
            PurchaseListView.Columns.Add("Price", 100);
            PurchaseListView.Columns.Add("Quantity", 100);
            PurchaseListView.Columns.Add("Total", 100);

        }


        public void AddtoPurchaseListView()
        {
            PurchaseListView.Items.Clear();
            productImage.Images.Clear(); // Clear previous images to avoid duplication

            foreach (var item in purchaseHandler.GetPurchaseItems())
            {
                ListViewItem listItem = new ListViewItem(item.ProductName);
                listItem.SubItems.Add(item.ProductPrice.ToString("₱#,##0.00"));
                listItem.SubItems.Add(item.Quantity.ToString());
                listItem.SubItems.Add(item.Total.ToString("₱#,##0.00"));

                // Convert byte array to image and add it to the ImageList
                if (item.ProductImage != null && item.ProductImage.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(item.ProductImage))
                    {
                        Image image = Image.FromStream(ms);
                        productImage.Images.Add(image);
                        listItem.ImageIndex = productImage.Images.Count - 1;
                    }
                }

                listItem.Tag = item.ProductID;
                PurchaseListView.Items.Add(listItem);
            }

            Totals();
        }

        private void Totals()
        {
            decimal subtotal = CalculateSubtotal();
            decimal tax = CalculateTax(subtotal);
            decimal totalAmount = CalculateTotal(subtotal, tax);

            Subtotallabl.Text = subtotal.ToString("₱#,##0.00");
            lblTax.Text = tax.ToString("₱#,##0.00");
            lblTotal.Text = totalAmount.ToString("₱#,##0.00");
        }



        public void ClearCart()
        {
            // Clear the cart items in the PurchaseHandler
            purchaseHandler.ClearCart();

            // Clear the ListView display
            PurchaseListView.Items.Clear();
            productImage.Images.Clear();

            // Clear the totals
            Subtotallabl.Text = "₱0.00";
            lblTax.Text = "₱0.00";
            lblTotal.Text = "₱0.00";
        }

        public List<PurchaseModel> GetPurchaseItems()
        {
            return purchaseHandler.GetPurchaseItems();
        }


        // methods to calculate subtotal, tax, and total
        private decimal CalculateSubtotal()
        {
            decimal subtotal = 0;
            foreach (ListViewItem item in PurchaseListView.Items)
            {
                decimal itemTotal;
                if (decimal.TryParse(item.SubItems[3].Text.Replace("₱", "").Trim(), out itemTotal))
                {
                    subtotal += itemTotal;
                }
            }
            return subtotal;
        }

        private decimal CalculateTax(decimal subtotal)
        {
            return subtotal * 0.02m; // Assuming 5% tax
        }

        private decimal CalculateTotal(decimal subtotal, decimal tax)
        {
            return subtotal + tax;
        }


        //flow layout panel click event
        private void ProductControl_AddToCartClicked(object sender, EventArgs e)
        {
            var productControl = sender as ProductUserControl;
            if (productControl != null)
            {
                var products = dbContext.GetProducts(); // Call GetProducts() method
                var product = products.FirstOrDefault(p => p.ProductName == productControl.name);
                if (product != null)
                {


                    // Create the PurchaseModel from the ProductUserControl data
                    PurchaseModel purchaseItem = new PurchaseModel
                    {
                        ProductID = product.ProductID,
                        ProductName = productControl.name,
                        ProductPrice = productControl.price,
                        Quantity = 1, // Default quantity
                        Tax = 0, // Initialize tax if necessary
                        added_date = DateTime.Now,
                        ProductImage = productControl.image // Assign the image data
                    };

                    // Add the item to the cart
                    purchaseHandler.AddtoCart(purchaseItem);
                    AddtoPurchaseListView();

                }
            }

        }
        // it fetches products from database and display at the flowlayoupanel
        public void DisplayProductsInMainPanel()
        {
            flpProductMain.Controls.Clear();

            List<ProductModel> products = dbContext.GetProducts();

            foreach (ProductModel product in products)
            {
                ProductUserControl productControl = new ProductUserControl
                {
                    name = product.ProductName,
                    price = product.ProductPrice,
                    image = product.ProductImage,
                    ShowDeleteButton = false //HIDE THE DELETE BUTTON IN MAINFORM
                };

                // this event is wired to handle adding the product
                productControl.AddtoCartClicked += ProductControl_AddToCartClicked;
                flpProductMain.Controls.Add(productControl);
            }
        }


        // Event handler for the Payment Button click event
        private void PayBTN_Click(object sender, EventArgs e)
        {

            // Calculate the subtotal, tax, and total
            decimal subtotal = CalculateSubtotal();
            decimal tax = CalculateTax(subtotal);
            decimal total = CalculateTotal(subtotal, tax);


            PaymentForm paymentForm = new PaymentForm(subtotal, tax, total);
            paymentForm.Owner = this;
            paymentForm.ShowDialog();
        }

        private void btnClearAll_Click_1(object sender, EventArgs e)
        {
            purchaseHandler.ClearCart();

            // Clear the ListView display
            PurchaseListView.Items.Clear();
            productImage.Images.Clear();
            // Clear the totals
            Subtotallabl.Text = "₱0.00";
            lblTax.Text = "₱0.00";
            lblTotal.Text = "₱0.00";

            // Clear the purchases in the database
            purchaseDBContext.ClearAllPurchases();
        }


       
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchBox.Text.Trim().ToLower();

            // Filter products based on the search query
            List<ProductModel> filteredProducts = dbContext.GetProducts()
                .Where(p => p.ProductName.ToLower().Contains(searchQuery)).ToList();

            // Clear and re-display products in the FlowLayoutPanel
            flpProductMain.Controls.Clear();

            foreach (ProductModel product in filteredProducts)
            {
                ProductUserControl productControl = new ProductUserControl
                {
                    name = product.ProductName,
                    price = product.ProductPrice,
                    image = product.ProductImage,
                    ShowDeleteButton = false // Hide delete button in MainForm
                };

                // this event is wired to handle adding the product
                productControl.AddtoCartClicked += ProductControl_AddToCartClicked;
                flpProductMain.Controls.Add(productControl);

            }
        }

        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            PrintReceiptForm printForm = new PrintReceiptForm();

            printForm.GetListViewFromPOS(PurchaseListView.Items);
            

            printForm.ShowDialog();

        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (formImage != null)
            {
                // Get the size of the printable area
                Rectangle printArea = e.PageBounds;

                // Maintain aspect ratio while scaling the image
                float scale = Math.Min(printArea.Width / (float)formImage.Width, printArea.Height / (float)formImage.Height);

                int scaledWidth = (int)(formImage.Width * scale);
                int scaledHeight = (int)(formImage.Height * scale);

                // Draw the scaled image on the print page
                e.Graphics.DrawImage(formImage, 0, 0, scaledWidth, scaledHeight);
            }
        }
        // Create a bitmap method to capture the PrintReceiptform as an image

        private void PrintBUTTON_Click(object sender, EventArgs e)
        {
            printReceiptForm.Show();
            printReceiptForm.WindowState = FormWindowState.Normal; // Ensure the form is not minimized
            printReceiptForm.BringToFront(); // Bring it to the front in case it's covered by other windows

            // Allow time for the form to render (you can add Application.DoEvents if needed)
            printReceiptForm.PerformLayout();
          
           
            // Ensure the form layout is complete
            printReceiptForm.GetListViewFromPOS(PurchaseListView.Items);
            

            // Capture the form image
            formImage = printReceiptForm.CaptureReceiptAsImage();

            // Optional: Hide the form after capturing if it's not needed anymore
            printReceiptForm.Hide();

            // Show the print preview dialog
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


    }
}
