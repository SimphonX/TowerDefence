

using System;
using System.Collections.Generic;
/**
* @(#) ProjectileDecorator.cs
*/
namespace towers_classes
{
	public abstract class ProjectileDecorator : AbstractProjectileContainer
	{
        AbstractProjectileContainer projectile;

        public ProjectileDecorator(int x, int y) : base(x, y)
        {
        }

        public void setProjectile(AbstractProjectileContainer projectile)
        {
            this.projectile = projectile;
        }

        public override string[] getEffects()
        {
            string[] effects = new string[0];

            if (projectile != null)
            {
                effects = this.projectile.getEffects();
            }
            return effects;
        }
        public override bool updateLocation()
        {
            return projectile.updateLocation();
        }
    }	
}
