using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
   public sealed class Singleton
    {
        private static Singleton objSingle;
        public static object locksafe = new object();

        private Singleton()
        {

        }

        public static Singleton instance
        {
            get
            {
                if (objSingle == null)
                    lock (locksafe)
                    {
                        objSingle = new Singleton();
                    }

                return objSingle;
            }
        }



    }

    public sealed class LazySingleton
    {
        public static object lockSfe = new object();
        private static readonly Lazy<LazySingleton> objSingleton = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance

        {

            get

            {

                return objSingleton.Value;

            }

        }
    }
}
