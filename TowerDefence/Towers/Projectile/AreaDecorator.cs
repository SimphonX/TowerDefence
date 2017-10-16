/**
 * @(#) AreaDecorator.cs
 */

namespace towers_classes
{
    public class AreaDecorator : ProjectileDecorator
    {
        public AreaDecorator(int x, int y, int tx, int ty, string effect) : base(x, y, tx, ty, effect)
        {
        }
    }

}
