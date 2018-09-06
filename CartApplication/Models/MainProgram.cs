using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace CartApplication.Models
{
    public class MainProgram
    {
        //created a cart
        Cart cart = new Cart();

        void mainfun()
        {
            int opt, pmethod;
            Console.WriteLine("Enter which operation you want to perform 1: display cart 2: Add to cart 3: Remove item from cart 4: clear cart 5: Purchase items from the cart");
            opt = Int32.Parse(Console.ReadLine());
            Items item = new Items();
            ItemPrice calculateItemPrice;

            Ipayment paymentType;

            switch (opt)
            {
                case 1:
                    cart.ShowItems();
                    break;
                case 2:
                    Console.WriteLine("enter the item details you wnat to add");
                    Console.WriteLine("enter itemName");

                    item.itemName = Console.ReadLine();
                    Console.WriteLine("enter itemPrice");
                    item.itemPrice = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter itemQty");
                    item.itemQty = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter itemId");
                    item.itemId = Int32.Parse(Console.ReadLine());
                    cart.AddItemIn(item);
                    break;
                case 3:
                    cart.Remove(item);
                    break;
                case 4:
                    cart.ClearItems();
                    break;
                case 5:
                    pmethod = Int32.Parse(Console.ReadLine());
                    if (pmethod == 1)

                        paymentType = new CardPayment();
                    else

                        paymentType = new CashPayment();
                    calculateItemPrice = new ItemPrice();

                    cart.CheckOut(paymentType, calculateItemPrice);
                    break;
            }
        }
    }


}