using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeInfo objEmployee = new Employee();
            Employee emp = new Employee();
            Console.WriteLine("Basic Information");
            Console.WriteLine(emp.GetDepertment());
            Console.WriteLine(objEmployee.GetPrimarySkill());
            Console.WriteLine(objEmployee.GetProject());

            Console.WriteLine("Secondary Skill - Level 1");
            IEmployeeInfo objSec1Employee = new DecorateEmployee(objEmployee);
            Console.WriteLine(objSec1Employee.GetPrimarySkill());
            Console.WriteLine(objSec1Employee.GetProject());

            Console.WriteLine("Secondary Skill - Level 2");
            IEmployeeInfo objSec2Employee = new DecorateEmployeeL2(objEmployee);
            Console.WriteLine(objSec2Employee.GetPrimarySkill());
            Console.WriteLine(objSec2Employee.GetProject());

            Console.WriteLine("All Skills");
            IEmployeeInfo objSec3Employee = new DecorateEmployeeL2(objSec1Employee);
            Console.WriteLine(objSec3Employee.GetPrimarySkill());
            Console.WriteLine(objSec3Employee.GetProject());

            Console.ReadKey();
        }
    }
}
