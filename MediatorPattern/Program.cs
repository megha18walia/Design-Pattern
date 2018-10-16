using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new Mediator();
            Colleague head1 = new Colleague(m, "Megha");
            ColleagueB branch = new ColleagueB(m, "Test");
            Colleague head2 = new Colleague(m, "Mohit");
            

            head1.Send("Meeting is there in Thursday, Plesae ack");
            branch.Send("Ack");
            m.Block(branch.Receive);
            head1.Send("Still waiting for Ack ");
            head2.Send("Ack");
            m.UnBlock(branch.Receive);
            head1.Send("Thanks All");
            Console.ReadLine();

        }
    }
}
