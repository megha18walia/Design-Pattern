using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
   public interface IBag
    {
       string Material { get; }
    }

    public interface IShoes
    {
        int Price { get; }
    }
}
