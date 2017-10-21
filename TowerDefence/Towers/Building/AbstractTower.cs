/**
 * @(#) AbstractTower.cs
 */

namespace towers_classes
{
	public abstract class AbstractTower : AbstractBuilding, TowerInterface
	{
		private int id;
		
		private string description;
		
		private int cost;
		
		private int damage;
		
		private LevelState state;

        public AbstractTower(int x, int y, int maxHealth, int cost) : base(x,y,maxHealth,cost)
        {
            this.state = new Level1();
        }

        public void fire( int x, int y )
		{
            if (state.GetType().Name == "Level1")
            {

            }
            else if (state.GetType().Name == "Level2")
            {

            }
            else
            {

            }
		}

        public LevelState LevelState
        {
            get { return state; }
            set
            {
                state = value;
            }
        }
		
		public Memento createMemento(  )
		{
			return null;
		}
		
		public void setMemento( Memento memento )
		{
			
		}
		
	}
	
}
