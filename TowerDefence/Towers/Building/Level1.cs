/**
 * @(#) Level1.cs
 */

namespace towers_classes
{
    public class Level1 : LevelState
    {
        public override void Handle(AbstractTower tower)
        {
            tower.LevelState = new Level1();
        }
    }

}
