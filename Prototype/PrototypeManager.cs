using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable()]
    class PrototypeManager : IPrototype<Prototypes>
    {
        public Dictionary<string, Prototypes> lstPrototype = new Dictionary<string, Prototypes> {
            { "German",
                        new Prototypes ("Germany", "Berlin", "German") },
            {"Italy",
                        new Prototypes ("Italy", "Rome", "Italian")},
            {"Australia",
                        new Prototypes("Australia", "Canberra", "English")}
            };

    }
}
