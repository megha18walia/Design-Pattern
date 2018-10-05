using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class FileLogger : AbstractLogger
    {
        public override void CloseConnection()
        {
            Console.WriteLine("Closing a file");
        }

        public override void ConnectToStorage()
        {
            Console.WriteLine("Opening a File");
        }

        public override void LogMessage(string s)
        {
            Console.WriteLine("Message logged to file : " + s);
        }


    }
}
