/**
 * @(#) TeslaZap.cs
 */

namespace towers_classes
{
    public class TeslaZap : AbstractProjectile
    {
        public TeslaZap(int x, int y, int tx, int ty, string effect, int dmg) : base(x, y, tx, ty, effect, dmg)
        {
            this.velocity = 1;
        }
    }

}
