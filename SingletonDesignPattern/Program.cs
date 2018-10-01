using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.instance;
            Singleton s1 = Singleton.instance;

            if(s == s1)
            {
                Console.WriteLine("Same object instance created");
            }

            LazySingleton obj = LazySingleton.Instance;
            LazySingleton obj2 = LazySingleton.Instance;

            if (obj == obj2)
            {
                Console.WriteLine("Same object instance created");
            }


        }
    }
}
