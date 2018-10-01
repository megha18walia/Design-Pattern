using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public class FlyWeightFactory
    {
        Dictionary<int, IFlyWeight> flyWeights = new Dictionary<int, IFlyWeight>();

        public FlyWeightFactory()
        {
            flyWeights.Clear();
        }

        public IFlyWeight this[int index]
        {
            get
            {
                if (flyWeights.ContainsKey(index))
                    return flyWeights[index];
                else
                {
                    flyWeights[index] = new FlyWeight();
                    return flyWeights[index];
                }
            }
        }
    }
}
