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
            return "You are already moving in a blind Panic";
        }
        public override string Attack(Context s)
        { return "You are already attacking in a blind Panic"; }
        public override string Stop(Context s) {
            s.State = new MovingState();
            return "You are in a moving state but slow down";
        }
        public override string Run(Context s) {
            return "You are already running around in Panic";
        }
        public override string Panic(Context s) {
            return "You are already in Panic state";
        }
        public override string CalmDown(Context s) {
            s.State = new RestingState();
            return "You should Calm Down";
        }
    }
}
