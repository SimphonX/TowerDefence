using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Main
{
    public class Cursor
    {
        private int x { get; set; }
        private int y { get; set; }

        public Cursor(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public void move(int x, int y)
        {
            this.x = x; this.y = y;
        }
    }
}
