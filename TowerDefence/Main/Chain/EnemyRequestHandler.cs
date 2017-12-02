using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enemys.Wave;
using Enemys.Effect;
using Enemys.Units;
using Enemys;
namespace TowerDefence.Main.ChainOfResponsibilities
{
    public class EnemyRequestHandler : RequestHandler
    {
        private static UnitDeployment enemyUnits = new UnitDeployment();
        public override void ExecuteModule(string Request)
        {
            if (Request == "Attack")
            {
              
                Console.ForegroundColor = System.ConsoleColor.Blue;
                Enemy();
            }
            else
            {
                next.ExecuteModule(Request);
            }
        }

        public override void setNextChain(RequestHandler next)
        {
            this.next = next;
        }

        public static void Enemy()
        {
            enemyUnits.Wave = new NormalWave();
            enemyUnits.Start(1);
            enemyUnits.Attack();
            Unit unit = new GoldUnit(1);
            Effect tower = new IceEffect(unit);
            EffectHistory hist = new EffectHistory();
            if (tower.Execute()) hist.AddEffect(tower);
            hist.UndoEffect();
        }
    }
}
