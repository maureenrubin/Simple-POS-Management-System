using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.FORMS;

namespace WindowsApp.PRINT
{
    public partial class PrintReceiptForm : Form
    {
 
        public PrintReceiptForm()
        {
          
            InitializeComponent();
            SetuplistViewPrint();

        }

      

        private void SetuplistViewPrint()
        {
            listViewPrint.View = View.Details;
            listViewPrint.Columns.Add("Product", 200);
            listViewPrint.Columns.Add("Price", 100);
            listViewPrint.Columns.Add("Quantity", 100);
            listViewPrint.Columns.Add("Total", 100);
        }
        public void GetListViewFromPOS(ListView.ListViewItemCollection items)
        {
            listViewPrint.Items.Clear();

            foreach (ListViewItem item in items)
            {
                ListViewItem clonedItem = (ListViewItem)item.Clone(); // Clone items from the MainForm's ListView
                listViewPrint.Items.Add(clonedItem);
            }

            Totals();
        }

        private decimal CalculateSubtotal()
        {
            decimal subtotal = 0;
            foreach (ListViewItem item in listViewPrint.Items)
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

        private void Totals()
        {
            decimal subtotal = CalculateSubtotal();
            decimal tax = CalculateTax(subtotal);
            decimal totalAmount = CalculateTotal(subtotal, tax);

            Subtotallabl.Text = subtotal.ToString("₱#,##0.00");
            lblTax.Text = tax.ToString("₱#,##0.00");
            lblTotal.Text = totalAmount.ToString("₱#,##0.00");
        }




        public Bitmap CaptureReceiptAsImage()
        {

            // Get the full dimensions of the form
            Rectangle bounds = this.Bounds;

            // Create a bitmap with the full dimensions of the form
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);

            // Draw the entire form onto the bitmap
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

            return bitmap;
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
