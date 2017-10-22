/**
 * @(#) AbstractBuilding.cs
 */

namespace towers_classes
{
	public abstract class AbstractBuilding : ExistingItem, BuildingInterface
	{
        protected int cost;

        protected int health;

        protected int maxHealth;

        public AbstractBuilding(int x, int y, int maxHealth, int cost):base(x,y)
        {
            this.maxHealth = maxHealth; health = maxHealth; this.cost = cost;
        }

        public void Damage(int value)
        {
            health -= value;
        }

        public void Repair(int value)
        {
            health += value;
            if (health > maxHealth) health = maxHealth;
        }
		
	}
	
}
