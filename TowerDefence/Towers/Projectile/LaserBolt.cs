/**
 * @(#) LaserBolt.cs
 */

namespace towers_classes
{
    public class LaserBolt : AbstractProjectile
    {
        public LaserBolt(int x, int y, int tx, int ty, string effect, int dmg) : base(x, y, tx, ty, effect, dmg)
        {
            this.velocity = 1.0;
        }
    }

}
