using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class OpenBook : ISpaceBook
    {
        private readonly SpaceBook objsBook;

        public  OpenBook()
        { 
            objsBook = new SpaceBook();
        }
        public void AddUser(User user)
        {
            objsBook.Add(user);
        }

        public void DeleteUser(string userName)
        {
            objsBook.Delete(userName);
        }

        public void UpdateUser(User user)
        {
            objsBook.Update(user);
        }
    }
}
