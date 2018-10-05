using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    class MovingState : IState
    {
        public override string Move(Context s) {
            return "You are already moving randomly";
        }
        public override string Attack(Context s) {
            return "You need to stop moving first";
        }
        public override string Stop(Context s) {
            s.State = new RestingState();
            return "You stand still in the dark room";
        }
        public override string Run(Context s) { return "You are already running around"; }
        public override string Panic(Context s) {
            s.State = new PanickingState();
            return "You start panicking and begin seeing things";
        }
        public override string CalmDown(Context s) {
            s.State = new RestingState();
            return "Yoy stand still and relax";
        }
    }
}
