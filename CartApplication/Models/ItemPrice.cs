using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartApplication.Models
{
    public class ItemPrice
    {
        public float totalPrice;

        public void CalculateTotalPrice(Ipayment paymentMethod,List<Items>items)
        {
            foreach(Items item in items)
            {
              this.totalPrice = this.totalPrice + item.itemPrice;
            }
            paymentMethod.paymentMethod(this.totalPrice);
           
        }

    }
}