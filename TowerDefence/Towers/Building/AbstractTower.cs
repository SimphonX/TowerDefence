

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
            this.state = new Level1(this);
        }

        public abstract AbstractProjectileContainer fire(int x, int y);

        public abstract AbstractProjectileContainer prepareShot(int tx, int ty, int dmg);

        public LevelState LevelState
        {
            get { return state; }
            set { state = value; }
        }

        public Memento backupState()
        {
            Console.WriteLine(this.GetType().Name + " is saving previous state as a memento");
            return new Memento(this, state);
        }

        public void setState(LevelState state)
        {
            this.state = state;
        }

        public void upgrade()
        {
            this.state = this.state.upgrade();
        }

        public int getDamage()
        {
            return damage;
        }

        public void destroy()
        {
            Console.WriteLine(this.GetType().Name+" is being destroyed");
            state = new Destroyed(this);
        }
    }
	
}
