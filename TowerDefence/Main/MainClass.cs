using Enemys;
using System;
using Enemys.Wave;
using Enemys.Effect;
using Enemys.Units;

namespace Main
{
    public class MainClass
    {
		 static MinionDecoyBoss JerryBoss = MinionDecoyBoss.getInstance();  //Sukuriam defenderių bosą
       static MinionFixerBoss LarryBoss = MinionFixerBoss.getInstance();  //Sukuriam fixerių bosą
	   
        private static UnitDeployment enemyUnits = new UnitDeployment();
        public static void Main()
        {
          MinionFixersDoSmthng();
            MinionDecoysDefend();
			 Console.ReadKey();
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
            if(tower.Execute()) hist.AddEffect(tower);
            hist.UndoEffect();
            //setup();
        }
		 public static void MinionFixersDoSmthng()
        {
            MinionFixerUnit fixer = new MinionFixerUnit("MinionFixer_Nr1",100,"Ready", LarryBoss);
            MinionFixerUnit fixerClone=(MinionFixerUnit)fixer.createClone();
            fixerClone.setName("FixerCloneNr1");
            MinionFixerUnit fixerClone2 = (MinionFixerUnit)fixer.createClone();
            fixerClone2.setName("FixerCloneNr2");
            MinionFixerUnit fixerClone3 = (MinionFixerUnit)fixer.createClone();
            fixerClone3.setName("FixerCloneNr3");
            LarryBoss.addMinion(fixer);
            LarryBoss.addMinion(fixerClone);
            LarryBoss.addMinion(fixerClone2);
            LarryBoss.addMinion(fixerClone3);
            LarryBoss.notify();

        }
        public static void MinionDecoysDefend()
        {
            MinionMovingDecoyUnit movingDecoy = new MinionMovingDecoyUnit("MinionMovingDecoy_Nr1", 100, "Ready", JerryBoss);
            MinionMovingDecoyUnit movingDecoyClone = (MinionMovingDecoyUnit)movingDecoy.createClone();
            movingDecoyClone.setName("MovingDecoyClone");
            MinionStandingDecoyUnit standingDecoy = new MinionStandingDecoyUnit("MinionStandingDecoy_Nr1", 100, "Ready", JerryBoss);
            MinionStandingDecoyUnit standingDecoyClone = (MinionStandingDecoyUnit)standingDecoy.createClone();
            standingDecoyClone.setName("StandingDecoyClone");
            JerryBoss.addMinion(movingDecoy);
            JerryBoss.addMinion(movingDecoyClone);
            JerryBoss.addMinion(standingDecoy);
            JerryBoss.addMinion(standingDecoyClone);
            JerryBoss.notify();

        }
        public static void setup()
        {
            Console.SetWindowSize(201, 50);
            Console.CursorVisible = false;
            run();
        }
        public static void run()
        {
            string s = MakeScreen(CreateGrid(50, 200, 's'));
            //Console.Clear();
            Console.Write(s);
            System.Threading.Thread.Sleep(500);
            run();
        }
        public static string MakeScreen(string [,] grid)
        {
            string[] arr = new string[grid.GetLength(0)];
            for(int i = 0; i < arr.Length; i++)
            {
                for(int ii = 0; ii< grid.GetLength(1); ii++)
                {
                    arr[i] += grid[i, ii];
                }
                arr[i] += '\n';
            }
            return String.Join("",arr);
        }

        public static string[,] CreateGrid(int h, int w, char s)
        {
            string[,] grid = new string[h, w];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int ii = 0; ii < grid.GetLength(1); ii++)
                {
                    if (ii % 5 == 0)
                    {
                        grid[i, ii] = ((char)186).ToString();
                    }
                    else
                    {
                        grid[i, ii] = s.ToString();
                    }

                }
            }
            return grid;
        }
    }

}
