using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towers_classes
{
    public class ExistingItem
    {
        //always shows current location
        protected int x;
        protected int y;
        public ExistingItem(int x, int y)
        {
            this.x = x; this.y = y;
        }
    }
}
