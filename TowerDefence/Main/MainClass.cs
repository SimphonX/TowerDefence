using Enemys;
using System;
using Enemys.Wave;
using Enemys.Effect;
using Enemys.Units;

namespace Main
{
    public class MainClass
    {
        private static UnitDeployment enemyUnits = new UnitDeployment();
        public static void Main()
        {
            Enemy();
            Console.ReadKey();
        }
        public static void Enemy()
        {
            enemyUnits.Wave = new NormalWave();
            enemyUnits.Start(1);
            enemyUnits.Attack();
            Unit unit = new GoldUnit(1);
            Effect tower = new IceEffect(unit);
            EffectHistory hist = new EffectHistory();
            if(tower.Execute()) hist.AddEffect();

        }
    }

}