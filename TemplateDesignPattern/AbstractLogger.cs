using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public abstract class AbstractLogger
    {
        public string SerializeMessage(string s)
        {
            Console.WriteLine("Message Serialized " + s);
            return s;
        }

        public abstract void ConnectToStorage();

        public abstract void LogMessage(string s);

        public abstract void CloseConnection();

        public void Log(string m)
        {
            string message = SerializeMessage(m);
            ConnectToStorage();
            LogMessage(message);
            CloseConnection();
        }
    }
}
