

using System.Collections.Generic;
/**
* @(#) ProjectileDecorator.cs
*/
namespace towers_classes
{
	public class ProjectileDecorator : AbstractProjectile
	{
		AbstractProjectile projectile;

        public ProjectileDecorator(int x, int y, int tx, int ty, string effect) : base(x, y, tx, ty, effect)
        {
        }

        public void setProjectile(AbstractProjectile projectile)
        {
            this.projectile = projectile;
        }

        public List<string> getEffectList()
        {
            List<string> eff = new List<string>();
            if (projectile != null)
            {
                eff.Add(projectile.getEffects());
            }
            eff.Add(base.getEffects());
            return eff;
        }
    }
	
}
