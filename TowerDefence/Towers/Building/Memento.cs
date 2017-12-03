

using System;
/**
* @(#) Memento.cs
*/
namespace towers_classes
{
	public class Memento
	{
        private AbstractTower tower;
		private LevelState state;
		
        public Memento( AbstractTower tower, LevelState state)
        {
            this.tower = tower; this.state = state;
        }
		
		public void restore(  )
		{
            Console.WriteLine(this.tower.GetType().Name + " is being restored to backed up state which is " + this.state.GetType().Name);
            tower.setState(state);
		}
		
	}
	
}
