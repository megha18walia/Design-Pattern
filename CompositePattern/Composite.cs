using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Composite<T> : IComponent<T>
    {
        public T Item { get; set; }

        public List<IComponent<T>> lstComposite;

        public  Composite(T Name)
        {
            Item = Name;
            lstComposite = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> objComp)
        {
            lstComposite.Add(objComp);
        }

        public string Display(int depth)
        {
            StringBuilder s = new StringBuilder(new string('-', depth));
            s.Append("Set name : " + Item + " Count : " + lstComposite.Count);
            foreach (var lstobj in lstComposite)
            {
                s.Append(lstobj.Display(depth+2));
            }

           return s.ToString();
        }

        public IComponent<T> Find(T objComp)
        {
            if (objComp.Equals(Item))
            {
                return this;
            }
            IComponent<T> result = null;
            foreach (var objlst in lstComposite)
            {
                result = objlst.Find(Item);
                if(result !=  null)
                    break;
                ;
            }

            return result;
        }

        public IComponent<T> Remove(T objComp)
        {
            IComponent<T> objFound = null;
            foreach (var objlst in lstComposite)
            {
                objFound = objlst.Find(objComp);
                if (objFound != null)
                {
                    lstComposite.Remove(objFound);
                    break;
                }
            }

            return objFound;
        }
    }
}
