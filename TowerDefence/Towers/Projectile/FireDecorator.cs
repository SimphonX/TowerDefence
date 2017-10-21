/**
 * @(#) FireDecorator.cs
 */

namespace towers_classes
{
    public class FireDecorator : ProjectileDecorator
    {
        public FireDecorator(int x, int y, int tx, int ty, string effect) : base(x, y, tx, ty, effect)
        {
        }
    }

}
