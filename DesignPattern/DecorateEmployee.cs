using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class DecorateEmployee : IEmployeeInfo
    {
        private readonly IEmployeeInfo objInfo;

        public DecorateEmployee(IEmployeeInfo iemployeeInfo)
        {
            objInfo = iemployeeInfo;
        }

        public string GetPrimarySkill()
        {
            string s = "Basic Skill : " + objInfo.GetPrimarySkill();
            s += " Advanced skill : Azure";
            return s;
        }

        public string GetProject()
        {
            string s = "Level 1 Project : " + objInfo.GetProject();
            s += "Level 2 Project : Uniper";
            return s;
        }
    }
}
