using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartApplication.Models
{
    public class PaymentType
    {
        Ipayment paymentType;
        public void SetCashPayment()
        {
            paymentType = new CashPayment();
        }

        public void SetCardPayment()
        {
            paymentType = new CardPayment();
        }

    }
}