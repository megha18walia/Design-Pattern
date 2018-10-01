using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
   public class SpaceBook
    {
        public static Dictionary<string, User> lstFreinds = new Dictionary<string, User>();

        public void Add(User user)
        {
            if(lstFreinds.ContainsKey(user.UserName))
            {
                Console.WriteLine(user.UserName + "already exist in your freind list");
            }
            else
            {
                lstFreinds.Add(user.UserName, user);
                Console.WriteLine(user.UserName + "added successfully in your freind list");
            }

          Display();
        }

        public  void Update(User user)
        {
            if (lstFreinds.ContainsKey(user.UserName))
            {
                lstFreinds[user.UserName] = user;
                Console.WriteLine(user.UserName+" updated succesfully");
            }
            else
            {
                Console.WriteLine(user.UserName + " does not exist in your freind list");
            }
            Display();
        }

        public void Delete(string user)
        {
            if (lstFreinds.ContainsKey(user))
            {
                lstFreinds.Remove(user);
                Console.WriteLine(user + " deleted succesfully");
            }
            else
            {
                Console.WriteLine(user + " does not exist in your freind list");
            }
            Display();
        }

        public void Display()
        {
            foreach (var key in lstFreinds.Keys)
            {
                Console.WriteLine("User Name " + lstFreinds[key].UserName);
                Console.WriteLine("User Location " + lstFreinds[key].Location);
                Console.WriteLine("User Birthday " + lstFreinds[key].Birthday.ToShortDateString());
                Console.WriteLine("User Company " + lstFreinds[key].Company);
            }
           
        }

    }
}
