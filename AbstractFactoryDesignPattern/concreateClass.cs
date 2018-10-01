using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class Bag<Brand> : IBag where Brand : IBrand , new()
    {
        private Brand myBrand;
        public Bag()
        {
            myBrand = new Brand();
        }
        public string Material => myBrand.Material;
    }

    public class Shoes<Brand> : IShoes where Brand : IBrand, new()
    {
        private Brand myBrand;

        public Shoes()
        {
            myBrand = new Brand();
        }
        public int Price => myBrand.Price;
    }
}
