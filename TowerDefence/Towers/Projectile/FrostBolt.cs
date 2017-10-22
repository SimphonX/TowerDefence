/**
 * @(#) FrostBolt.cs
 */

namespace towers_classes
{
    public class FrostBolt : AbstractProjectile
    {
        public FrostBolt(int x, int y, int tx, int ty, string effect, int dmg) : base(x, y, tx, ty, effect, dmg)
        {
            this.velocity = 0.5;
        }
    }

}
