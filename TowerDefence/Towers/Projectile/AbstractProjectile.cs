/**
 * @(#) AbstractProjectile.cs
 */

namespace towers_classes
{
	public abstract class AbstractProjectile: ExistingItem
	{
		int id;
		
		int start_x;
		
		int start_y;
		
		int target_x;
		
		int target_y;
		
		int velocity;

        string effect { get; set; }

        public AbstractProjectile(int x, int y, int tx, int ty, string effect) : base(x, y)
        {
            this.start_x = x; this.start_y = y; this.target_x = tx; this.target_y = ty; this.effect = effect;
        }

        public string getEffects()
        {
            return effect;
        }
    }
	
}
