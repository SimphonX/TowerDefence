

using System;
/**
* @(#) Level1.cs
*/
namespace towers_classes
{
    public class Level1 : LevelState
    {
        private const int DAMAGEMULTIPLYER = 1;
        public Level1(AbstractTower tower) : base(tower)
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
            Console.WriteLine(" Upgrading tower from Level1 to Level2");
            return new Level2(this.context);
        }
    }

}
