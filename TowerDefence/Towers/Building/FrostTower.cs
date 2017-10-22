

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
            switch (this.state.GetType().Name)
            {
                case "Level 1":
                    projectile = this.prepareShot(x, y, this.damage * 1);
                    break;
                case "Level 2":
                    projectile = this.prepareShot(x, y, this.damage * 2);
                    break;
                default:
                    projectile = this.prepareShot(x, y, this.damage * 3);
                    break;
            }
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
