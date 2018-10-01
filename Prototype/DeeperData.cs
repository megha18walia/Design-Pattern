using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable()]
    public class DeeperData
    {
        public string Data { get; set; }
        public DeeperData(string data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data;
        }
    }
}
