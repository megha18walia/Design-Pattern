using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
   public class MyAggregate : IAggregate
    {
        List<string> values = null;

        public MyAggregate()
        {
            values = new List<string>();
        }
        public string this[int itemIndex]
        {
            get
            {
                if(itemIndex < values.Count)
                {
                    return values[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                values.Add(value);
            }
        }

        public int count => values.Count;

        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }
    }
}
