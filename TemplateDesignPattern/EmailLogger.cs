using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class EmailLogger : AbstractLogger
    {
        public override void CloseConnection()
        {
            Console.WriteLine("Connection to emial closed");
        }

        public override void ConnectToStorage()
        {
            Console.WriteLine("Connection To email opened");
        }

        public override void LogMessage(string s)
        {
            Console.WriteLine("Message sent in email : " + s);
        }
    }
}
