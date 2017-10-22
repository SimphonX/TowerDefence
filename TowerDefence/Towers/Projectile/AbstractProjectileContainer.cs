using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towers_classes
{
    public abstract class AbstractProjectileContainer : ExistingItem
    {
        public AbstractProjectileContainer(int x, int y) : base(x, y)
        {
        }
        public abstract string[] getEffects();
        public abstract bool updateLocation();
    }
}
