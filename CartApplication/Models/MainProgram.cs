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
        List<Items> items =
    new List<Items>()   {
        new Items
        {
             itemName="Bag",
             itemId=1,
             itemQty=2,
             itemPrice=100,
        },
          new Items
        {
             itemName="Top",
             itemId=1,
             itemQty=2,
             itemPrice=500,
        },

    };
    void mainfun()
        {
            char c = Console.ReadKey().KeyChar;

            Items item = new Items();
            Console.WriteLine(");
            cart.AddItemIn(item);
            cart.remove(item);
         
            //cart.SetCardPayment();
            cart.CheckOut(item);
            


        }
    }

    }
