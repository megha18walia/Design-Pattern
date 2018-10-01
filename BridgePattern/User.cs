using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
   public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
    }
}
