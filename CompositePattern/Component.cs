using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Component<T> : IComponent<T>
    {
        public T Item { get; set; }

        public Component(T name)
        {
            Item = name;
        }

        public void Add(IComponent<T> objComp)
        {
            Console.WriteLine("Component cannot be added this way");
        }

        public string Display(int depth)
        {
            return new string('-',depth ) + Item;
        }

        public IComponent<T> Find(T  objComp)
        {
            if (this.Item.Equals(objComp))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public IComponent<T> Remove(T objComp)
        {
            Console.WriteLine("Cannot remove directly");
            return this;
        }
    }
}
