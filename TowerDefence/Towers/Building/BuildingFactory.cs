/**
 * @(#) BuildingFactory.cs
 */

namespace towers_classes
{
	public class BuildingFactory : AbstractBuildingFactory
	{
		private static BuildingFactory instance;
		
		public BuildingFactory(  )
		{
			
		}
		
		public BuildingFactory getInstance(  )
		{
            if (instance == null)
            {
                instance = new BuildingFactory();
            }
            return instance;
        }

        public override AbstractBuilding createBuilding( string type )
		{
            switch (type)
            {
                case "wall":
                    return new Wall();
                case "rifle":
                    return new RifleTower();
                case "frost":
                    return new FrostTower();
                case "laser":
                    return new LaserTower();
                case "tesla":
                    return new TeslaTower();
                default:
                    return null;
            }
		}
    }
	
}
