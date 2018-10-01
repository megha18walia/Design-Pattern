using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public struct FlyWeight : IFlyWeight
    {
       public int width;
        public int height;
        int x;
        int y;
        public void Display(int num, int albumNum)
        {
            int i = num / 5;

            x = num * width;
            y = i * height;

            Console.WriteLine("Album Number : " + albumNum);
            Console.WriteLine("Image Coordinates " + x + " , " + y);
        }

        public void Load()
        {
            this.width = 10;
            this.height = 10;
        }
    }
}
