

using System;
/**
* @(#) FrostTower.cs
*/
namespace towers_classes
{
	public class FrostTower : AbstractTower
	{
        public FrostTower(int x, int y, int maxHealth=10, int cost=10) : base(x, y, maxHealth, cost)
        {
            this.damage = 1;
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
            FrostBolt baseProjectile = new FrostBolt(x, y, tx, ty, "base", dmg);
            SlowDecorator slowDecorated = new SlowDecorator(x, y);

            slowDecorated.setProjectile(baseProjectile);
            return slowDecorated;
        }
    }
	
}
