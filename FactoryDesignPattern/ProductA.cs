using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ProductA : IFactory
    {
        public string ShippedFrom()
        {
            return "United Kingdom";
        }
    }

    public class ProductB : IFactory
    {
        public string ShippedFrom()
        {
            return "United States Of America";
        }
    }

    public class ProductC : IFactory
    {
        public string ShippedFrom()
        {
            return "Germany";
        }
    }
}
