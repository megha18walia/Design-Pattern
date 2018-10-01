using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
   public static class ConstructBag
    {
        public static void DoWork(string workItem, int time)
        {
            Console.WriteLine(workItem + "creation in progress : 0%");
            Thread.Sleep(time);
            Console.WriteLine(workItem + "creation in progress : 25%");
            Thread.Sleep(time);
            Console.WriteLine(workItem + "creation in progress : 50%");
            Thread.Sleep(time);
            Console.WriteLine(workItem + "creation in progress : 75%");
            Thread.Sleep(time);
            Console.WriteLine(workItem + "creation in progress : 100%");
            Thread.Sleep(time);
        }
    }
}
