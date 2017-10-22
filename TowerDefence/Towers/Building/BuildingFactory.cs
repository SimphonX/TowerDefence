

using System;
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
            Console.WriteLine("New building factory created");
		}
		
		public static BuildingFactory getInstance(  )
		{
            if (instance == null)
            {
                instance = new BuildingFactory();
            }
            return instance;
        }

        public override AbstractBuilding createBuilding( string type, int x, int y )
		{
            switch (type)
            {
                case "wall":
                    return new Wall(x,y);
                case "rifle":
                    return new RifleTower(x,y);
                case "frost":
                    return new FrostTower(x,y);
                case "laser":
                    return new LaserTower(x,y);
                case "tesla":
                    return new TeslaTower(x,y);
                default:
                    return null;
            }
		}

        public override AbstractTower createTower(string type, int x, int y)
        {
            switch (type)
            {
                case "rifle":
                    return new RifleTower(x, y);
                case "frost":
                    return new FrostTower(x, y);
                case "laser":
                    return new LaserTower(x, y);
                case "tesla":
                    return new TeslaTower(x, y);
                default:
                    return null;
            }
        }
    }
	
}
