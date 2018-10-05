using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class DatabaseLogger : AbstractLogger
    {
        public override void CloseConnection()
        {
            Console.WriteLine("Connection to database closed");
        }

        public override void ConnectToStorage()
        {
            Console.WriteLine("Connection to database opened");
        }

        public override void LogMessage(string s)
        {
            Console.WriteLine("Log entered in database : " + s);
        }
    }
}
