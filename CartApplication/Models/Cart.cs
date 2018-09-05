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
        Ipayment paymentType;

       public void CheckOut(Items item)
        {
            paymentType.paymentMethod(item);
        }
 
      
        public void showItems()
        {

        }
        public void clear()
        {

        }

        public void AddItemIn( Items item)
        {
            //    ob.itemAdded.push();

        }
        public void remove(Items item)
        {
            //    ob.itemAdded.push();

        }
        
    }
}