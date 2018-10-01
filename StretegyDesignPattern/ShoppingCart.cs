using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretegyDesignPattern
{
   public class ShoppingCart
    {
        List<Item> lstshoppingItems = new List<Item>();

        public void AddItem(Item item)
        {
            lstshoppingItems.Add(item);
        }

        public void RemoveItem(Item item)
        {
            lstshoppingItems.Remove(item);
        }
        
        int CalculatePrice()
        {
            int price = lstshoppingItems.Select(p => p.Price).ToList().Sum();
            return price;
        }

        public void Pay(IPaymentStretegy stretegy)
        {
            stretegy.Pay(CalculatePrice());
        }
    }
}
