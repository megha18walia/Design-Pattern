using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class PanickingState : IState
    {
        public override string Move(Context s)
        {

        }
        public override string Attack(Context s) { return ""; }
        public override string Stop(Context s) { return ""; }
        public override string Run(Context s) { return ""; }
        public override string Panic(Context s) { return ""; }
        public override string CalmDown(Context s) { return ""; }
    }
}
