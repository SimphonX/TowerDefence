/**
 * @(#) SlowDecorator.cs
 */

namespace towers_classes
{
    public class SlowDecorator : ProjectileDecorator
    {
        public SlowDecorator(int x, int y, int tx, int ty, string effect) : base(x, y, tx, ty, effect)
        {
        }
    }

}
