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
            //setup();
            Console.ReadKey();
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