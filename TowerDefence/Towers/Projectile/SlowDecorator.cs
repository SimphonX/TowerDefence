

using System;
/**
* @(#) SlowDecorator.cs
*/
namespace towers_classes
{
    public class SlowDecorator : ProjectileDecorator
    {
        public SlowDecorator(int x, int y) : base(x, y)
        {
        }
        public override string[] getEffects()
        {
            string[] effects = base.getEffects();
            Array.Resize<string>(ref effects, effects.Length + 1);
            effects[effects.Length - 1] = this.AddFrostEffect();
            return effects;
        }

        private string AddFrostEffect()
        {
            return "chilled";
        }
    }

}
