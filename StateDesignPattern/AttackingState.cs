using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
   public class AttackingState : IState
    {
        public override string Move(Context s)
        {
            return "You need to stop attacking first";
        }
        public override string Attack(Context s) {
            return "You are attacking the darkness";
        }
        public override string Stop(Context s) {
            s.State = new RestingState();
            return "You have come to rest";
        }
        public override string Run(Context s) {
            s.State = new MovingState();
            return "Your Moving state has been initiated";
        }
        public override string Panic(Context s) {
            s.State = new PanickingState();
            return "You have entered in Panicking State";
        }
        public override string CalmDown(Context s) {
            s.State = new RestingState();
            return "You have calm down and will be in rest state eventually.";
        }
    }
}
