/**
 * @(#) Level3.cs
 */

namespace towers_classes
{
	public class Level3 : LevelState
	{
        public override void Handle(AbstractTower tower)
        {
            tower.LevelState = new Level3();
        }
    }
	
}
