using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client<Guchi>().ClientMain();
            new Client<Poochy>().ClientMain();
            new Client<Toochy>().ClientMain();
            Console.ReadLine();

        }
    }
}
