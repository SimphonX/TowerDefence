/**
 * @(#) AbstractBuildingFactory.cs
 */

namespace towers_classes
{
	public abstract class AbstractBuildingFactory
	{
        public abstract AbstractBuilding createBuilding(string type,int x,int y);
        public abstract AbstractTower createTower(string type, int x, int y);
	};	
}
