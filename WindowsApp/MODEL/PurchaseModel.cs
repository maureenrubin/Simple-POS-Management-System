using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.MODEL
{
    public class PurchaseModel
    {
        public int ProductID { get; set; }
        public int PurchaseID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Tax { get; set; }
        public byte[] ProductImage { get; set; }
   
        public  DateTime added_date { get; set; }
        public string CPno { get; set; }

        public string PaymentMethod { get; set; }
        public  decimal TSubtotal { get; set; }

        public decimal Total { get; set; }
    }
}
