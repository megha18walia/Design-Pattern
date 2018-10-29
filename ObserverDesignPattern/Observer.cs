using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IObserver
    {
        void Update(string state);
    }
    public class Observer : IObserver
    {
        string name;
        Subject subject;
        string state;
        string gap;

        public Observer(string name, Subject subject, string gap)
        {
            this.name = name;
            this.subject = subject;
            this.gap = gap;
            subject.Notify += Update;
        }
        
        public void Update(string state)
        {
            this.state = state;
            Console.WriteLine(gap + name + " : " + state);
        }
    }
}
