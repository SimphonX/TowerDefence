using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using towers_classes;

namespace TowerDefence.Main
{
    public class TowersDemo
    {
        public static void run()
        {
            BuildingFactory factory = BuildingFactory.getInstance();
            AbstractTower testTower1 = factory.createTower("frost", 0, 0);
            AbstractProjectileContainer testShot = testTower1.fire(2, 3);            
            while (!testShot.updateLocation())
            {
            }
            testShot = null;
        }
    }
}
