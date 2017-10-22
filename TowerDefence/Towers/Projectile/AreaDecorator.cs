

using System;
/**
* @(#) AreaDecorator.cs
*/
namespace towers_classes
{
    public class AreaDecorator : ProjectileDecorator
    {
        public AreaDecorator(int x, int y) : base(x, y)
        {
        }

        public override string[] getEffects()
        {
            string[] effects = base.getEffects();
            Array.Resize<string>(ref effects, effects.Length + 1);
            effects[effects.Length - 1] = this.AddAreaEffect();
            return effects;
        }

        private string AddAreaEffect()
        {
            return "area";
        }
    }

}
