using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class ClientMain <Brand> where Brand : IBrand, new()
    {
        public void CreateBags()
        {
            IBuilder<Brand> factory = new Builder<Brand>();
            DateTime date = DateTime.Now;
            Console.WriteLine("Bag Creation Started");
            factory.CreateBag();
            string s = DateTime.Now.Subtract(date).TotalSeconds.ToString();
            Console.WriteLine("Bag creation took " + s + " seconds");
        }
    }
}
