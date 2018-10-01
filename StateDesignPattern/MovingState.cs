using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class MovingState : IState
    {
        public virtual string Move(Context s) { return ""; }
        public virtual string Attach(Context s) { return ""; }
        public virtual string Stop(Context s) { return ""; }
        public virtual string Run(Context s) { return ""; }
        public virtual string Panic(Context s) { return ""; }
        public virtual string CalmDown(Context s) { return ""; }
    }
}
