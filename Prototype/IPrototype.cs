using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable()]
    public abstract class IPrototype<T>
    {
        public T clone()
        {
            return (T)this.MemberwiseClone();
        }

        public T DeepCopy()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);
            T copy = (T)bf.Deserialize(ms);
            ms.Close();
            return copy;

        }
    }
}
