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

namespace WindowsApp.PRINT
{
    public partial class PrintReceiptForm : Form
    {
        public PrintReceiptForm()
        {
            InitializeComponent();
            SetuplistViewPrint();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
       


       
    }
}
