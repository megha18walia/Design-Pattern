using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information");
            Facade.GetStudentInfo();

            Console.WriteLine("Employee Information");
            Facade.GetEmployeeInfo();

            Console.ReadKey();
        }
    }
}
