using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public abstract class Iterator
    {
        public abstract Boolean hasNext();
        public abstract Object next();
    }
}
