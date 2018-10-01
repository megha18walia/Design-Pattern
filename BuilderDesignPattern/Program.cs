using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClientMain<Guchi>().CreateBags();
            new ClientMain<Poochy>().CreateBags();
            Console.ReadLine();
        }
    }
}
