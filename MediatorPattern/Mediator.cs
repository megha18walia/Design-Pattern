using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Mediator
    {
        public delegate void Callback(string message, string form);
        Callback respond;

        public void SignOn(Callback method)
        {
            respond += method;
        }

        public void Block(Callback method)
        {
            respond -= method;
        }

        public void UnBlock(Callback method)
        {
            respond += method;
        }

        public void Send(string message, string form)
        {
            respond(message, form);
            Console.WriteLine();
        }
    }
}
