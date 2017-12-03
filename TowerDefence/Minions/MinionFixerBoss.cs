using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class MinionFixerBoss : AbstractMinionLeader
    {

        public static MinionFixerBoss instance;
        private MinionFixerBoss() { name = "LarryFixerBoss"; lifepoints = 1000;
            minions = new MinionRepository(); }
        public override void addMinion(AbstractCloneableMinion m)
        {
            if(m!=null)
            minions.Add((MinionFixerUnit)m);
            else { minions.Add(new NullObjectMinion()); }
        }

        public override void notify()
        {
            int tower = getTowerWithLeastLp();
            for (Iterator iter = minions.getIterator(); iter.hasNext();)
            {
                if(iter.next().GetType()== typeof(MinionFixerUnit)) { 
                MinionFixerUnit m = (MinionFixerUnit)iter.next();
                m.receiveCommand("StartFixing");
                }
            }
          

        }

        public override void removeMinion(AbstractCloneableMinion m)
        {
            minions.Remove((MinionFixerUnit)m);
        }
        public static MinionFixerBoss getInstance()
        {

            {
                if (instance == null)
                {
                    instance = new MinionFixerBoss();
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
