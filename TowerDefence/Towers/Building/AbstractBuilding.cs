/**
 * @(#) AbstractBuilding.cs
 */

namespace towers_classes
{
	public abstract class AbstractBuilding : BuildingInterface
	{
		int x;
		
		int y;
		
		int health;

        int maxHealth;

        public AbstractBuilding(int x, int y, int maxHealth)
        {
            this.x = x; this.y = y; this.maxHealth = maxHealth; health = maxHealth;
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
