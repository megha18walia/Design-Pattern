using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
   public class RestingState : IState
    {
        public override string Move(Context s) {
            s.State = new MovingState();
            return "You Start Moving";
        }
        public override string Attack(Context s) {
            s.State = new AttackingState();
            return "You Start Attacking";
        }
        public override string Stop(Context s) {
            return "You are already in resting state";
        }
        public override string Run(Context s) {
            return "You cannot Run as you are not in moving state";
        }
        public override string Panic(Context s) {
            s.State = new PanickingState();
            return "You Start Panic and begin seeing things";
        }
        public override string CalmDown(Context s) {
            return "You are already relaxed";
        }
    }
}
