

using System;
/**
* @(#) AbstractTower.cs
*/
namespace towers_classes
{
	public abstract class AbstractTower : AbstractBuilding, TowerInterface
	{
        protected int id;

        protected string description;

        protected int cost;

        protected int damage;

        protected LevelState state;

        public AbstractTower(int x, int y, int maxHealth, int cost) : base(x,y,maxHealth,cost)
        {
            this.state = new Level1();
        }

        public abstract AbstractProjectileContainer fire(int x, int y);

        public abstract AbstractProjectileContainer prepareShot(int tx, int ty, int dmg);

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
            state = memento.getState();
		}

        public void upgrade()
        {
            switch (state.GetType().Name)
            {
                case "Level1":
                    Console.WriteLine(this.GetType().Name + " upgraded to: Level 2");
                    state = new Level2();
                    break;
                case "Level2":
                    Console.WriteLine(this.GetType().Name + " upgraded to: Level 3");
                    state = new Level3();
                    break;
            }
        }
    }
	
}
