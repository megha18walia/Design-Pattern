using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Employee
    {
        internal void GetEmpName()
        {
            Console.WriteLine( "Employee name : Sarkar");
        }

        internal void GetDeartmentName()
        {
            Console.WriteLine("Department : IT");
        }

        internal void GetTechnology()
        {
            Console.WriteLine("Technology : Azure");
        }
            
    }
}
