using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class MinionFixerConveyor : AbstractMinionConveyor
    {
        public override void addRollerblades()
        {
            throw new NotImplementedException();
        }

        public override void addShield()
        {
            throw new NotImplementedException();
        }

        public override void addTools()
        {
            minion.addAtribute("Fixing tools");
            Console.WriteLine("[" + minion.getName() + "]" + DateTime.Now.ToString() + ": Fixing tools added");
        }

        public override bool needRollerBlades()
        {
            return false;
        }

        public override bool needShield()
        {
            return false;
        }

        public override bool needTools()
        {
            return true;
        }
    }
}
