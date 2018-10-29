using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
   public class Subject
    {
        public delegate void Callback(string s);
        public event Callback Notify;
        Simulator sim = new Simulator();
        const int speed = 200;

        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        public void Run()
        {
            foreach(string s in sim)
            {
                Console.WriteLine("Subject : " + s);
                SubjectState = s;
                Notify(s);
                Thread.Sleep(speed);
            }
        }


    }
}
