/**
 * @(#) LevelState.cs
 */

namespace towers_classes
{
	public abstract class LevelState
	{
        protected AbstractTower context;
        public LevelState(AbstractTower tower)
        {
            context = tower;
        }
        public abstract int Handle();
        public abstract LevelState upgrade();
	}
	
}
