using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
   public class Client
    {
        static FlyWeightFactory factory = new FlyWeightFactory();
        static Dictionary<int, List<int>> albumData = new Dictionary<int, List<int>>();

        public void LoadData()
        {
            var myData = new[] {
                                 new { Number = 1, Images = new[] { 1, 2, 3, 4, 5, 6, 7, 8 } },
                                 new { Number = 2, Images = new[]{ 1,2,3,4,5,6,7,8,9,10} },
                                 new { Number = 3, Images = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12 } },
                                 new { Number = 4, Images = new[]{ 1,2,3,4,5,6,7,8,9} }
            };

            foreach(var obj in myData)
            {
                albumData.Add(obj.Number, obj.Images.ToList<int>());

                foreach(var member in obj.Images)
                {
                    factory[member].Load();
                }
            }
        }

        public void DisplayGroup()
        {
            foreach(var obj in albumData)
            {
                foreach(var num in obj.Value)
                {
                    factory[num].Display(num, obj.Key);
                }
            }
        }
    }
}
