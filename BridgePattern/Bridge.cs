using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
   public class Bridge
   {
       private ISpaceBook objSpaceBook;

       public Bridge(ISpaceBook spacebook)
       {
           objSpaceBook = spacebook;
       }

       public  void AddUser(User user)
       { 
           objSpaceBook.AddUser(user);
       }

       public  void UpdateUser(User user)
       {
           objSpaceBook.UpdateUser(user);
       }

       public void DeleteUser(string userNme)
       {
           objSpaceBook.DeleteUser(userNme);
       }
   }
}
