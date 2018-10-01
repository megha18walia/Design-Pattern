using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public interface IFlyWeight
    {
        void Load();
        void Display(int num, int albumNum);
    }
}
