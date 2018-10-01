using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
   public interface IComponent<T>
    {
        T Item { get; set; }
        void Add(IComponent<T> objComp);

        IComponent<T> Remove(T objComp);

        IComponent<T> Find(T objComp);

        string Display(int depth);
    } 
}
