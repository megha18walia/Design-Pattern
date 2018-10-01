using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> Album = new Composite<string>("Album");

            Console.WriteLine("New Album Created");
            Console.WriteLine("Add Photos to Album");
            Album.Add(new Component<string>("Photo1"));
            Album.Add(new Component<string>("Photo2"));
            Album.Add(new Component<string>("Photo3"));
            Album.Add(new Component<string>("Photo4"));
            Console.WriteLine("Photos displayed after  being added");
            Console.WriteLine(Album.Display(4));
            Console.WriteLine("Delete Photo from Album");
            Album.Remove("Photo2");
            Console.WriteLine("Photos displayed after  being being deleted");
            Console.WriteLine(Album.Display(4));
            Console.ReadLine();

        }
    }
}
