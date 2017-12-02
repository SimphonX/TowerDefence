using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class MinionStandingDecoyConveyor : AbstractMinionConveyor
    {
        public override void addRollerblades()
        {
            throw new NotImplementedException();
        }

        public override void addShield()
        {
            Console.WriteLine("[" + minion.getName() + "]" + DateTime.Now.ToString() + ": Shield added");
        }

        public override void addTools()
        {
            throw new NotImplementedException();
        }

        public override bool needRollerBlades()
        {
            return false;
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
