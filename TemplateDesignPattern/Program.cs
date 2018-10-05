using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logging Framework");

            FileLogger file = new FileLogger();
            file.Log("Testing File Message");

            EmailLogger email = new EmailLogger();
            email.Log("Testing Email Message");

            DatabaseLogger database = new DatabaseLogger();
            database.Log("Testing Database Message");

            Console.ReadLine();
        }
    }
}
