using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ProductFactory
    {
        public  IFactory GetProduct(int month)
        {
            if (month >= 0 && month < 4)
                return new ProductA();
            else if (month >= 4 && month < 8)
                return new ProductB();
            else
                return new ProductC();
        }
    }
}
