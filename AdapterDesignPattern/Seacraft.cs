using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Seacraft : ISeacraft
    {
        int speed;

        public Seacraft()
        {
            speed = 0;
        }
        public int Speed => speed;

        public virtual void IncreaseRevolutions()
        {
            speed += 10;
            Console.WriteLine("Speed ha been increased by 1 rev " + speed);
        }
    }
}
