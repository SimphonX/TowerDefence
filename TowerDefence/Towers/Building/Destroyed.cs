

using System;
/**
* @(#) Level1.cs
*/
namespace towers_classes
{
    public class Destroyed : LevelState
    {
        public Destroyed(AbstractTower tower) : base(tower)
        {
        }

        public override int Handle()
        {
            Console.WriteLine(" This tower does no damage");
            return 0;
        }

        public override LevelState upgrade()
        {
            Console.WriteLine(" Upgrading tower from Destroyed to previous state");
            return new Level2(this.context);
        }
    }

}
