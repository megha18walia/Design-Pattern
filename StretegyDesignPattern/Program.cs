using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretegyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart card = new ShoppingCart();
            card.AddItem(new Item(200, "abc1"));
            card.AddItem(new Item(150, "abc2"));
            card.AddItem(new Item(300, "abc3"));

            card.Pay(new CreditCardStretegy("abc", "XXX1-XXX2-XXX3", "897", "15/01/1990"));
            card.Pay(new PayPalStretegy("abc@gmail.com", "pass"));
            Console.ReadLine();

        }
    }
}
