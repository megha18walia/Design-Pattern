using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Employee : IEmployeeInfo
    {
        public string GetDepertment()
        {
            return "Technology";
        }

        public string GetPrimarySkill()
        {
            return ".Net";
        }

        public string GetProject()
        {
            return "Chevron";
        }
    }
}
