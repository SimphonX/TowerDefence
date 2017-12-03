

using System;
/**
* @(#) RifleTower.cs
*/
namespace towers_classes
{
	public class RifleTower : AbstractTower
	{
        public RifleTower(int x, int y, int maxHealth=10, int cost=10) : base(x, y, maxHealth, cost)
        {
            this.damage = 2;
            Console.WriteLine(this.GetType().Name + " created At: X:" + x + "; Y:" + y);
        }

        public override AbstractProjectileContainer fire(int x, int y)
        {
            AbstractProjectileContainer projectile;
            projectile = this.prepareShot(x, y, this.state.Handle());
            Console.WriteLine(this.GetType().Name + " fired at target, at: X:" + x + "; Y:" + y + ". With projectile effects: " + String.Join(",", projectile.getEffects()));
            return projectile;
        }

        public override AbstractProjectileContainer prepareShot(int tx, int ty, int dmg)
        {
            Bullet baseProjectile = new Bullet(this.x, this.y, tx, ty, "base", dmg);
            return baseProjectile;
        }
    }
	
}
