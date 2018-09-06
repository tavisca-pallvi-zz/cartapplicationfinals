using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartApplication.Models
{
    public class Cart:ICart
    {
        
        public int cartId;
        private int quantity;
        public List<Items>itemAdded;
        public int totalPrice;
      

       public void CheckOut(Ipayment paymentType, ItemPrice calItemPrice)
        {
            calItemPrice.CalculateTotalPrice(paymentType, itemAdded);
          
        }
 
      
        public void ShowItems()
        {
            foreach(Items item in itemAdded)
            {
                Console.WriteLine(item);
            }

        }
        public void ClearItems()
        {
                itemAdded.Clear();
            
        }

        public void AddItemIn( Items item)

        {

            itemAdded.Add(item);

        }
        public void Remove(Items item)
        {
            itemAdded.Remove(item);

        }
        
    }
}