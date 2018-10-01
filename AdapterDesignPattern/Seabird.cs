using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Seabird : Seacraft, IAircraft
    {
        int heights;


        public int Height => heights;

        //Hide th eoriginal Take off to make Seabird work like an aircraft
        public void TakeOff()
        {
            IncreaseRevolutions();
        }

        public override void IncreaseRevolutions()
        {
            base.IncreaseRevolutions();
            if (Speed > 40)
                heights += 100;
        }
    }
}
