using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client objClient = new Client();
            objClient.LoadData();
            objClient.DisplayGroup();
            Console.ReadKey();
        }
    }
}
