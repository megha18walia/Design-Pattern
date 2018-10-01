using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test How aircraft works normally");
            IAircraft objCraft = new Aircraft();
            objCraft.TakeOff();
            Console.WriteLine("Original height of aircraft" + objCraft.Height);
           

            Console.WriteLine("Using Engine as Seabird");
            IAircraft seaCr = new Seabird();
            seaCr.TakeOff();
            Console.WriteLine("height of aircraft" + seaCr.Height);


            Console.WriteLine("Increase the speed of a sea craft");
            (seaCr as ISeacraft).IncreaseRevolutions();
            (seaCr as ISeacraft).IncreaseRevolutions();
            (seaCr as ISeacraft).IncreaseRevolutions();
            (seaCr as ISeacraft).IncreaseRevolutions();
            //(seaCr as ISeacraft).IncreaseRevolutions();
            //(seaCr as ISeacraft).IncreaseRevolutions();


            Console.WriteLine("Sea Bird is flying at a height of " + seaCr.Height + " and at speed of " + (seaCr as ISeacraft).Speed);
            Console.ReadLine();

        }

    }
}
