

using System;
/**
* @(#) FireDecorator.cs
*/
namespace towers_classes
{
    public class FireDecorator : ProjectileDecorator
    {
        public FireDecorator(int x, int y) : base(x, y)
        {
        }
        public override string[] getEffects()
        {
            string[] effects = base.getEffects();
            Array.Resize<string>(ref effects, effects.Length + 1);
            effects[effects.Length - 1] = this.AddFlameEffect();
            return effects;
        }

        private string AddFlameEffect()
        {
            return "fire";
        }
    }

}
