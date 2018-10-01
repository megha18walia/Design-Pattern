using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
   public interface ISpaceBook
   {
       void AddUser(User user);
       void UpdateUser(User user);
       void DeleteUser(string userName);

   }
}
