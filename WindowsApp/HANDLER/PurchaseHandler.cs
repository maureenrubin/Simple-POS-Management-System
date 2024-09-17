using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.MODEL;
using System.Collections.Generic; // For List<T>


namespace WindowsApp.HANDLER
{
    public class PurchaseHandler
    {
        private List<PurchaseModel> purchaseItems;

        public PurchaseHandler() 
        {
         purchaseItems = new List<PurchaseModel>();
        }

        public void AddtoCart(PurchaseModel purchaseItem)
        {
            var existingItem = purchaseItems.FirstOrDefault(item => item.ProductName == purchaseItem.ProductName);
            if (existingItem != null)
            {
                // Update the quantity of the existing item
                existingItem.Quantity += purchaseItem.Quantity;
                existingItem.Total = existingItem.Quantity * existingItem.ProductPrice; // Recalculate total
            }
            else
            {
                purchaseItem.Total = purchaseItem.Quantity * purchaseItem.ProductPrice; //
                // Add new item if it doesn't exist
                purchaseItems.Add(purchaseItem);
            }
        }

    

        public List <PurchaseModel> GetPurchaseItems()
        {
            return purchaseItems;
        }

        public void ClearCart()
        {
            purchaseItems.Clear();
        }

    

    }
}
