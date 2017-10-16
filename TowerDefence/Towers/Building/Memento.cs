/**
 * @(#) Memento.cs
 */

namespace towers_classes
{
	public class Memento
	{
		private LevelState state;
		
		public void setState( LevelState state )
		{
            this.state = state;
		}
		
		public LevelState getState(  )
		{
            return state;
		}
		
	}
	
}
