using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxySpaceBook objProxy = new ProxySpaceBook();
            objProxy.RegisterUser();
            if (objProxy.AuthenticateUser())
            {
                objProxy.AddUser(new User()
                {
                     Birthday = new DateTime(1990, 1,1),
                    Company =  "Sapient1",
                    Location =  "Delhi1",
                     UserId = new Guid(),
                    UserName = "Megha Walia1"
                });
                objProxy.AddUser(new User()
                {
                    Birthday = new DateTime(1990, 1, 2),
                    Company = "Sapient2",
                    Location = "Delhi2",
                    UserId = new Guid(),
                    UserName = "Megha Walia2"
                });
                objProxy.AddUser(new User()
                {
                    Birthday = new DateTime(1990, 1, 3),
                    Company = "Sapient3",
                    Location = "Delhi3",
                    UserId = new Guid(),
                    UserName = "Megha Walia3"
                });
                objProxy.AddUser(new User()
                {
                    Birthday = new DateTime(1990, 1, 4),
                    Company = "Sapient4",
                    Location = "Delhi4",
                    UserId = new Guid(),
                    UserName = "Megha Walia4"
                });
                objProxy.AddUser(new User()
                {
                    Birthday = new DateTime(1990, 1, 5),
                    Company = "Sapient5",
                    Location = "Delhi5",
                    UserId = new Guid(),
                    UserName = "Megha Walia5"
                });
                Console.WriteLine("\n******************************************************\n");

                objProxy.UpdateUser(new User()
                {
                    Birthday = new DateTime(1990, 1, 6),
                    Company = "Sapient6",
                    Location = "Delhi6",
                    UserId = new Guid(),
                    UserName = "Megha Walia5"
                });

                Console.WriteLine("\n******************************************************\n");

                objProxy.UpdateUser(new User()
                {
                    Birthday = new DateTime(1990, 1, 6),
                    Company = "Sapient6",
                    Location = "Delhi6",
                    UserId = new Guid(),
                    UserName = "Megha Walia5"
                });

                Console.WriteLine("\n******************************************************\n");
                objProxy.DeleteUser("Megha Walia5");
            }

            Console.ReadLine();

        }
    }
}
