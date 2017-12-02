using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class MinionMovingDecoyConveyor : AbstractMinionConveyor
    {
        public override void addRollerblades()
        {
            minion.addAtribute("RollerBlades");
            Console.WriteLine("[" + minion.getName() + "]" + DateTime.Now.ToString() + ": Rollerblades added");
        }

        public override void addShield()
        {
            minion.addAtribute("Shield");
            Console.WriteLine("[" + minion.getName() + "]" + DateTime.Now.ToString() + ": Shield added");
        }

        public override void addTools()
        {
            throw new NotImplementedException();
        }

        public override bool needRollerBlades()
        {
            return true;
        }

        public override bool needShield()
        {
            return true;
        }

        public override bool needTools()
        {
            return false;
        }
    }
}
