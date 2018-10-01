using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
   public class Context
    {
        public IState State { get; set; }

        public void Request(char c)
        {
            
        }
    }
}
