/**
 * @(#) TowerInterface.cs
 */

namespace towers_classes
{
	public interface TowerInterface
	{
        AbstractProjectileContainer fire( int x, int y );
        void upgrade();
	}
	
}
