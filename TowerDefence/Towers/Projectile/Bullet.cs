/**
 * @(#) Bullet.cs
 */

namespace towers_classes
{
    public class Bullet : AbstractProjectile
    {
        public Bullet(int x, int y, int tx, int ty, string effect, int dmg) : base(x, y, tx, ty, effect, dmg)
        {
            this.velocity = 0.7;
        }
    }

}
