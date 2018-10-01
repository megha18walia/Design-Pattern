using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
   public class Client<Brand> where Brand : IBrand , new()
    {
        public void ClientMain()
        {
            IFactory factory = new Factory<Brand>();
            IBag bag = new Bag<Brand>();
            IShoes shoes = new Shoes<Brand>();

            Console.WriteLine("New Bag Created : Material " + bag.Material);
            Console.WriteLine("New Shoe Created : Price " + shoes.Price);

        }
        
    }
}
