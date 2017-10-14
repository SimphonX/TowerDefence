/**
 * @(#) AbstractBuildingFactory.cs
 */

namespace towers_classes
{
	public abstract class AbstractBuildingFactory
	{
        public abstract AbstractBuilding createBuilding(string type);		
	};	
}
