

using System;
/**
* @(#) Level3.cs
*/
namespace towers_classes
{
	public class Level3 : LevelState
	{
        private const int DAMAGEMULTIPLYER = 3;
        public Level3(AbstractTower tower) : base(tower)
        {
        }

        public override int Handle()
        {
            int damage = this.context.getDamage();
            double finalDamage = damage * DAMAGEMULTIPLYER;
            Console.WriteLine(" Final damage for shot: " + finalDamage);
            return damage * DAMAGEMULTIPLYER;
        }

        public override LevelState upgrade()
        {
            Console.WriteLine(" Cannot upgrade tower further");
            return this;
        }
    }
	
}
