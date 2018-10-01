using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Poochy : IBrand
    {
        public IBag CreateBag()
        {
            IBag objBag = new Bag();
            ConstructBag.DoWork("Hire Cheap labour", 100);
            ConstructBag.DoWork("Cut Plastic", 200);
            ConstructBag.DoWork("Sew Plastic", 300);
            objBag.Properties += " Plastic Done!!!!";

            ConstructBag.DoWork("Add Label", 150);
            objBag.Properties += " Label Added !!!";
            return objBag;
        }
    }

    public class Guchi : IBrand
    {
        public IBag CreateBag()
        {
            IBag bag = new Bag();
            ConstructBag.DoWork("Cut Leather", 200);
            ConstructBag.DoWork("Sew Leather", 300);
            bag.Properties += " Leather Prepared !!!";
            ConstructBag.DoWork("Create Lining", 100);
            ConstructBag.DoWork("Attach Lining", 200);
            bag.Properties += " Lining Added";
            ConstructBag.DoWork("Add Label", 200);
            bag.Properties += " Label Added";
            return bag;


        }
    }
}
