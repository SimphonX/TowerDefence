using Enemys;
using System;
using Enemys.Wave;
using Enemys.Effect;
using Enemys.Units;
using TowerDefence.Minions;
using TowerDefence.Main;
using TowerDefence.Main.ChainOfResponsibilities;

namespace Main
{
    public class MainClass
    {

        public static void Main()
        {
            RequestHandler M1 = new MinionRequestHandler();
            RequestHandler T1 = new TowerRequestHandler();
            RequestHandler E1 = new EnemyRequestHandler();

            T1.setNextChain(E1);
            E1.setNextChain(M1);
            M1.setNextChain(T1);

            RequestHandler mainHandler = T1;

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                string request = "";
                switch (keyinfo.Key)
                {
                    case ConsoleKey.A:
                        {
                            request = "Attack";
                            break;
                        }
                    case ConsoleKey.T:
                        {
                            request = "TowersStart";
                            break;
                        }
                    case ConsoleKey.M:
                        {
                            request = "MinionsDefend";
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            request = "MinionsFix";
                            break;
                        }

                }
                if (!string.IsNullOrWhiteSpace(request))
                {
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine();
                    mainHandler.ExecuteModule(request);
                }


            }
            while (keyinfo.Key != ConsoleKey.X);
        }



    }
}
