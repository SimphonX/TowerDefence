using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class MinionDecoyBoss : AbstractMinionLeader
    {
        public static MinionDecoyBoss instance;
        private MinionDecoyBoss() { name = "JerryDecoyBoss"; lifepoints = 1000; minions = new List<AbstractCloneableMinion>(); }
        public override void addMinion(AbstractCloneableMinion m)
        {
            if (m != null)
                minions.Add(m);
            else
                minions.Add(new NullObjectMinion());
        }

        public override void removeMinion(AbstractCloneableMinion M)
        {
            minions.Remove(M);
        }

        public override void notify()
        {

            foreach (AbstractCloneableMinion m in minions)
            {
                if(m!=null)
                m.receiveCommand("StartDefending");
              
            }
        }

        public static MinionDecoyBoss getInstance()
        {

            {
                if (instance == null)
                {
                    instance = new MinionDecoyBoss();
                }
                return instance;
            }
        }

        public override int getTowerWithLeastLp()
        {
            int[] x = new int[] { 100, 64, 50, 60, 70 };
            int s = x.Min();
            return s;
        }
    }
}
