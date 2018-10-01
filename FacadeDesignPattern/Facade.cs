using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class Facade
    {
        static Employee objEmp = new Employee();
        static Student objStu = new Student();

        public static void GetEmployeeInfo()
        {
            objEmp.GetEmpName();
            objEmp.GetDeartmentName();          
            objEmp.GetTechnology();
        }

        public static void GetStudentInfo()
        {
            objStu.getName();
            objStu.getClass();
            objStu.getFavSub();
        }
    }
}
