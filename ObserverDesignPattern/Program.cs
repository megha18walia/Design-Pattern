using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject();
            Observer ob1 = new Observer("Centre", sub, "\t\t");
            Observer ob2 = new Observer("Right", sub, "\t\t\t\t");
            sub.Go();
            Console.ReadLine();
        }
    }

    public class Simulator : IEnumerable
    {
        string[] moves = { "5", "4", "3", "2", "1" };

        public IEnumerator GetEnumerator()
        {
            foreach(string s in moves)
            {
                yield return s;
            }
        }
    }
}
