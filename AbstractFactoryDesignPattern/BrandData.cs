using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class Guchi : IBrand
    {
        public int Price => 10000;
        public string Material => "Leather";
       
    }

    public class Poochy : IBrand
    {
       public int Price => 2000;

       public string Material => "Farzi Leather";
    }

    public class Toochy : IBrand
    {
        public int Price => 1000;

        public string Material => "Plastic";
    }
}
