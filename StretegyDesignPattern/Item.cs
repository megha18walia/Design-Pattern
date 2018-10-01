using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretegyDesignPattern
{
   public class Item
    {
        string barcode;
        int price;

        public string BarCode { get; set; }
        public int Price { get { return price; } } 

        public Item(int p, string b)
        {
            barcode = b;
            price = p;
        }
    }
}
