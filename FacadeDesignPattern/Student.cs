using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class Student
    {
        public void getName()
        {
            Console.WriteLine("Student Name : Test");
        }

        public void getClass()
        {
            Console.WriteLine(" Class : Third");
        }
        public void getFavSub()
        {
            Console.WriteLine("Subject : Maths");
        }
    }
}
