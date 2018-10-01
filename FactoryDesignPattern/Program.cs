using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory prod = new ProductFactory();
            IFactory factory;

            for(int i = 0; i< 12; i++)
            {
                factory = prod.GetProduct(i);
                Console.WriteLine("Avogado for Month : " + i + " --> " + factory.ShippedFrom());
            }

            Console.ReadLine();
        }
    }
}
