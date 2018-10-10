using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    delegate void Invoker();

    static class InvokerExtensions
    {
        static int count;
        public static int Count(this Invoker invoker)
        {
            return count;
        }

        public static void Log(this Invoker invoker)
        {
            count++;
        }
    }
}
