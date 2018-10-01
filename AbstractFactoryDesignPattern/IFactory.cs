using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    interface IFactory
    {
        IBag CreateBag();
        IShoes CreateShoes();
    }
}
