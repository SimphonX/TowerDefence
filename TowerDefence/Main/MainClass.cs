using Enemys;
using System;
using Enemys.Wave;

namespace Main
{
    public class MainClass
    {
        private static UnitDeployment enemyUnits = new UnitDeployment();
        public static void Main()
        {
            enemyUnits.Wave = new NormalWave();
            enemyUnits.Start(1);
            enemyUnits.Attack();
            Console.ReadKey();
        }
    }

}