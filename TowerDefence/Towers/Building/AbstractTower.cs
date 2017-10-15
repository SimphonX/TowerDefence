/**
 * @(#) AbstractTower.cs
 */

namespace towers_classes
{
	public abstract class AbstractTower : AbstractBuilding, TowerInterface
	{
		int id;
		
		string description;
		
		int cost;
		
		int damage;
		
		LevelState state;

        public AbstractTower(int x, int y, int maxHealth) : base(x,y,maxHealth)
        {

        }
		
		public void fire( int x, int y )
		{
			
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
