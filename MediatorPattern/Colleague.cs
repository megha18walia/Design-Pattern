using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
   public class Colleague
    {
        Mediator mediator;
        public string name;

        public Colleague(Mediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
            this.mediator.SignOn(Receive);
        }

        public virtual void Receive(string message, string form)
        {
            if (!String.Equals(form, name))
            {
                Console.WriteLine(name + " received from " + form + " : " + message);
            }
        }

        public void Send(string message)
        {
            Console.WriteLine("Send From : " + name + " Message : " + message);
            mediator.Send(message, name);
        }
    }

    public class ColleagueB : Colleague
    {
        public ColleagueB(Mediator mediator, string name) : base(mediator, name)
        {

        }

        public override void Receive(string message, string form)
        {
            if(! String.Equals(form, name))
            {
                Console.WriteLine(name + "received from " + form + " : " + message);
            }
        }
    }
}
