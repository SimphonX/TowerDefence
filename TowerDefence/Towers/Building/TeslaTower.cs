

using System;
/**
* @(#) TeslaTower.cs
*/
namespace towers_classes
{
	public class TeslaTower : AbstractTower
	{
        public TeslaTower(int x, int y, int maxHealth=10, int cost=10) : base(x, y, maxHealth, cost)
        {
            this.damage = 1;
            Console.WriteLine(this.GetType().Name + " created At: X:" + x + "; Y:" + y);
        }

        public override AbstractProjectileContainer fire(int x, int y)
        {
            AbstractProjectileContainer projectile;
            projectile = this.prepareShot(x, y, this.state.Handle());
            Console.WriteLine(this.GetType().Name + " fired at target, at: X:" + x + "; Y:" + y +". With projectile effects: "+String.Join(",",projectile.getEffects()));
            return projectile;
        }

        public override AbstractProjectileContainer prepareShot(int tx, int ty, int dmg)
        {
            TeslaZap baseProjectile = new TeslaZap(this.x, this.y, tx, ty, "base", dmg);
            FireDecorator fireWrapper = new FireDecorator(this.x, this.y);
            AreaDecorator areaWrapper = new AreaDecorator(this.x, this.y);
            fireWrapper.setProjectile(baseProjectile);
            areaWrapper.setProjectile(fireWrapper);
            return baseProjectile;
        }
    }
	
}
