using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
  public  interface IIterator
    {
        string FirstItem { get; }
        string NextItem { get;  }
        string CurrentItem { get;  }
        bool IsDone { get;  }

    }

   public interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { get; set; }
        int count { get; }
    }
}
