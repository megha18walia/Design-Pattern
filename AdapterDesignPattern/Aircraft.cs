using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Aircraft : IAircraft
    {
        public int heights;

        public Aircraft()
        {
            heights = 0;
        }

       public int Height => heights;



        public void TakeOff()
        {
            Console.WriteLine("Air craft take off");
            heights = 200;
        }
    }
}
