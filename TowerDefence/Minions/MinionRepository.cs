using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class MinionRepository : Container
    {
        public static List<AbstractCloneableMinion> minions = new List<AbstractCloneableMinion>();
        public override Iterator getIterator()
        {
            return new MinionIterator();
        }

        public void Add(AbstractCloneableMinion m)
        {
            minions.Add(m);
        }
        public void Remove(AbstractCloneableMinion m)
        {
            minions.Remove(m);
        }

        private class MinionIterator : Iterator
        {
            int index;

            public override bool hasNext()
            {
                if (index < minions.Count)
                    return true;
                return false;
            }

            public override object next()
            {
                if (this.hasNext())
                    return minions[index++];
                return null;
            }
        }
    }
}
