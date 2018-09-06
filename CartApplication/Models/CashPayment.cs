using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartApplication.Models
{
    public class CashPayment:Ipayment
    {
      
        public void paymentMethod(float cashAmount)
        {
            Console.WriteLine("Payable Amount:" + cashAmount);

        }
    }
}