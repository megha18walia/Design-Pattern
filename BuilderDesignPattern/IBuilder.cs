using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
   public interface IBuilder<Brand> where Brand : IBrand
    {
        IBag CreateBag();
    }
}
