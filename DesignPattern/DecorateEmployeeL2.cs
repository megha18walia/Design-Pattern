using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class DecorateEmployeeL2 : IEmployeeInfo
    {
        private readonly IEmployeeInfo iinfo;

        public DecorateEmployeeL2(IEmployeeInfo ieEmployeeInfo)
        {
            iinfo = ieEmployeeInfo;
        }
        public string GetPrimarySkill()
        {
            string s = iinfo.GetPrimarySkill();
            s += " Secontry Skill : VSTS";
            return s;
        }

        public string GetProject()
        {
            string s = iinfo.GetProject();
            s += " Another Project : E.ON";
            return s;
        }
    }
}
