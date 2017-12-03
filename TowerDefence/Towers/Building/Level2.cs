

using System;
/**
* @(#) Level2.cs
*/
namespace towers_classes
{
	public class Level2 : LevelState
	{
        private const int DAMAGEMULTIPLYER = 2;
        public Level2(AbstractTower tower) : base(tower)
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
            Console.WriteLine(" Upgrading tower from Level2 to Level3");
            return new Level3(this.context);
        }
    }
	
}
