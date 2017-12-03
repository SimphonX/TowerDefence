using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefence.Minions;

namespace TowerDefence.Main.ChainOfResponsibilities
{
    public class MinionRequestHandler : RequestHandler
    {
        static MinionDecoyBoss JerryBoss = MinionDecoyBoss.getInstance();  //Sukuriam defenderių bosą
        static MinionFixerBoss LarryBoss = MinionFixerBoss.getInstance();  //Sukuriam fixerių bosą
        static ChatRoom CM = new ChatRoom(); //Mediatorius komunikacijai
        public override void ExecuteModule(string Request)
        {
            if(Request=="MinionsDefend")   //StartDefenders
            {
           
                Console.ForegroundColor = System.ConsoleColor.Green;
                MinionDecoysDefend();
            }
            else if(Request=="MinionsFix")  //StartFixers
            {
                Console.ForegroundColor = System.ConsoleColor.Green;
                MinionFixersDoSmthng();

            }
            else
            {
                next.ExecuteModule(Request);
            }


        }

        public static void MinionFixersDoSmthng()
        {
            MinionFixerConveyor FixerConveyor = new MinionFixerConveyor();
            MinionFixerUnit fixer = (MinionFixerUnit)FixerConveyor.BuildMinion("Fixer", "MinionFixer_Nr1", 100, "Ready", LarryBoss, CM);
            MinionFixerUnit fixerClone = (MinionFixerUnit)fixer.createClone();
            fixerClone.setName("FixerCloneNr1");
            MinionFixerUnit fixerClone2 = (MinionFixerUnit)fixer.createClone();
            fixerClone2.setName("FixerCloneNr2");
            MinionFixerUnit fixerClone3 = (MinionFixerUnit)fixer.createClone();
            fixerClone3.setName("FixerCloneNr3");
            fixerClone3.send("Taking fire need assistance");
            CM.addMinion(fixer);
            CM.addMinion(fixerClone);
            CM.addMinion(fixerClone2);
            CM.addMinion(fixerClone3);
            LarryBoss.addMinion(fixer);
            LarryBoss.addMinion(fixerClone);
            LarryBoss.addMinion(fixerClone2);
            LarryBoss.addMinion(fixerClone3);
            LarryBoss.notify();

        }

        public static void MinionDecoysDefend()
        {
           
            MinionMovingDecoyConveyor MovingDecoyConveyor = new MinionMovingDecoyConveyor();
            MinionStandingDecoyConveyor StandingDecoyConveyor = new MinionStandingDecoyConveyor();
            MinionMovingDecoyUnit movingDecoy = (MinionMovingDecoyUnit)MovingDecoyConveyor.BuildMinion("MovingDecoy", "MinionMovingDecoy_Nr1", 100, "Ready", JerryBoss, CM);
            MinionMovingDecoyUnit movingDecoyClone = (MinionMovingDecoyUnit)movingDecoy.createClone();
            movingDecoyClone.setName("MovingDecoyClone");
            MinionStandingDecoyUnit standingDecoy = (MinionStandingDecoyUnit)StandingDecoyConveyor.BuildMinion("StandingDecoy", "MinionStandingDecoy_Nr1", 100, "Ready", JerryBoss, CM);
            MinionStandingDecoyUnit standingDecoyClone = (MinionStandingDecoyUnit)standingDecoy.createClone();
            standingDecoyClone.setName("StandingDecoyClone");
            CM.addMinion(movingDecoy);
            CM.addMinion(movingDecoyClone);
            CM.addMinion(standingDecoy);
            CM.addMinion(standingDecoyClone);
            movingDecoyClone.send("Roger that");
            JerryBoss.addMinion(movingDecoy);
            JerryBoss.addMinion(movingDecoyClone);
            JerryBoss.addMinion(standingDecoy);
            JerryBoss.addMinion(standingDecoyClone);
            JerryBoss.notify();

        }

        public override void setNextChain(RequestHandler next)
        {
            this.next = next;
        }
    }
}
