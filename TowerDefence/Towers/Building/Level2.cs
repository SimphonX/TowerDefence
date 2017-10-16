/**
 * @(#) Level2.cs
 */

namespace towers_classes
{
	public class Level2 : LevelState
	{
        public override void Handle(AbstractTower tower)
        {
            tower.LevelState = new Level2();
        }
    }
	
}
