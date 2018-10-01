using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public abstract class IState
    {
        public virtual string Move(Context s) { return ""; }
        public virtual string Attack(Context s) { return ""; }
        public virtual string Stop(Context s) { return ""; }
        public virtual string Run(Context s) { return ""; }
        public virtual string Panic(Context s) { return ""; }
        public virtual string CalmDown(Context s) { return ""; }
    }
}
