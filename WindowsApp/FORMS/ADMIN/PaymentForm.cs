using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.DATA_ACCESS;
using WindowsApp.MODEL;

namespace WindowsApp.FORMS
{
    public partial class PaymentForm : Form
    {
        private decimal subtotal;
        private decimal tax;
        private decimal total;


        public PaymentForm( decimal subtotal, decimal Tax, decimal total)
        {
            InitializeComponent();
            this.subtotal = subtotal;
            this.tax = Tax;
            this.total = total;

            DisplayTotals();
        }

        private void DisplayTotals()
        {
            lblSubtotal.Text = subtotal.ToString("₱#,##0.00");
            lblTax.Text = tax.ToString("₱#,##0.00");
            lblTotal.Text = total.ToString("₱#,##0.00");
            txtAmount.Text = total.ToString("₱#,##0.00");
        }

        private void PayBTN_Click(object sender, EventArgs e)
        {
      
            
            if (rbCash.Checked || rbGcash.Checked || rbPaypal.Checked)
            {
                // Check if an account number is required for the selected payment method
                if ((rbGcash.Checked || rbPaypal.Checked) && string.IsNullOrWhiteSpace(txtAccountNumber.Text))
                {
                    MessageBox.Show("Please enter your account number for the selected payment method.", "Account Number Required");
                    return;
                }

                // Determine the payment method and account number
                string paymentMethod = rbCash.Checked ? "Cash" :
                                       rbGcash.Checked ? "Gcash" :
                                                         "Paypal";

                string accountNumber = (rbGcash.Checked || rbPaypal.Checked) ? txtAccountNumber.Text : null;


                //Fetch purchase items from the Main form
                MainForm mainform = (MainForm)Owner;
                List<PurchaseModel> purchaseItems = mainform.GetPurchaseItems();

               // Save the purchases to the database
                foreach (var item in purchaseItems)
                {
                    item.PaymentMethod = paymentMethod;
                    item.CPno = accountNumber;
                    item.Tax = this.tax;
                 
                }
                PurchaseDBContext purchaseDBContext = new PurchaseDBContext();
                purchaseDBContext.SaveCart(purchaseItems);


                // Handle payment logic here
                MessageBox.Show($"Payment of {total.ToString("₱#,##0.00")} via {paymentMethod} , {accountNumber} completed successfully!", "Payment Success");

                ClearCartData();
                this.Close();
            }

            else
            {
                MessageBox.Show("Please select a payment method.", "Payment Method Required");
            }
        }


        private void ClearCartData()
        {
            MainForm mainForm = (MainForm)Owner; // Assuming PaymentForm was shown as a dialog from MainForm
            mainForm.ClearCart(); // This method should clear the cart and refresh after payment

            // Additional clean-up logic if necessary
            txtAmount.Text = string.Empty;
            txtAccountNumber.Text = string.Empty;
        }

     

        private void CancelPayBTN_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }
    }

}
