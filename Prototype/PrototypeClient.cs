using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeClient : IPrototype<Prototypes>
    {
        public static void Report(string s, Prototypes a, Prototypes b)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("Prototype " + a + "\n Clone " + b);
        }

        public static void TestClone()
        {
            PrototypeManager mgr = new PrototypeManager();
            Prototypes c2, c3;

            c2 = mgr.lstPrototype["Australia"].clone();
            Report("Shallow Cloning \n", mgr.lstPrototype["Australia"], c2);

            c2.Capital = "Sydney";
            Report("Shallow Cloning Unaffected \n", mgr.lstPrototype["Australia"], c2);

            c2.Language.Data = "Chinese";
            Report("Shallow Cloning Unaffected \n", mgr.lstPrototype["Australia"], c2);

            c3 = mgr.lstPrototype["German"].DeepCopy();

            Report("Deep Cloning \n", mgr.lstPrototype["German"], c3);

            c3.Capital = "Munich";
            Report("Deep Cloning Unaffected \n", mgr.lstPrototype["German"], c3);

            c3.Language.Data = "Turkish";
            Report("Deep Cloning Unaffected \n", mgr.lstPrototype["German"], c3);

        }

    }
}
