using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridge objBridge = new Bridge(new ProxySpaceBook());
            objBridge.AddUser(new User()
            {
                Birthday = new DateTime(1990, 1, 1),
                Company = "Sapient1",
                Location = "Delhi1",
                UserId = new Guid(),
                UserName = "Megha Walia1"
            });

            objBridge.AddUser(new User()
            {
                Birthday = new DateTime(1990, 1, 2),
                Company = "Sapient2",
                Location = "Delhi2",
                UserId = new Guid(),
                UserName = "Megha Walia2"
            });

            Console.WriteLine("\n*************************************************************\n");

            objBridge.UpdateUser(new User()
            {
                Birthday = new DateTime(1990, 1, 3),
                Company = "Sapient3",
                Location = "Delhi3",
                UserId = new Guid(),
                UserName = "Megha Walia2"
            });

            Console.WriteLine("\n*************************************************************\n");

            objBridge.DeleteUser("Megha Walia2");

            Console.WriteLine("\n*************************************************************\n");

            objBridge = new Bridge(new OpenBook());
            objBridge.AddUser(new User()
            {
                Birthday = new DateTime(1990, 1, 4),
                Company = "Sapient4",
                Location = "Delhi4",
                UserId = new Guid(),
                UserName = "Megha Walia4"
            });

            objBridge.AddUser(new User()
            {
                Birthday = new DateTime(1990, 1, 5),
                Company = "Sapient5",
                Location = "Delhi5",
                UserId = new Guid(),
                UserName = "Megha Walia5"
            });

            Console.WriteLine("\n*************************************************************\n");

            objBridge.UpdateUser(new User()
            {
                Birthday = new DateTime(1990, 1, 6),
                Company = "Sapient6",
                Location = "Delhi6",
                UserId = new Guid(),
                UserName = "Megha Walia5"
            });

            Console.WriteLine("\n*************************************************************\n");

            objBridge.DeleteUser("Megha Walia5");

            Console.ReadLine();


        }
    }
}
