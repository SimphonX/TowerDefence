using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Main
{
    public class View
    {
        private int sizeX;
        private int sizeY;
        private string[,] view;
        private int mapX;

        public View(int x, int y)
        {
            sizeX = x; sizeY = y;
            view = new string[y, x];
            for(int i = 0; i < view.GetLength(0); i++)
            {
                for(int ii = 0; ii< view.GetLength(1); ii++)
                {
                    view[i, ii] = " ";
                }
            }
        }

        public void redrawMap(string[,] map)
        {
            mapX = map.GetLength(1);
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for (int ii = 0; ii < map.GetLength(1); ii++)
                {
                    view[i,ii] = map[i,ii];
                }
            }
        }
        public void redrawUI(string[,] ui)
        {
            for(int i = 0; i < ui.GetLength(0); i++)
            {
                for(int ii = mapX; ii < ui.GetLength(1); ii++)
                {
                    view[i, ii] = ui[i, (ii - mapX)];
                }
            }
        }
        public string render()
        {
            string[] arr = new string[view.GetLength(0)];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int ii = 0; ii < view.GetLength(1); ii++)
                {
                    arr[i] += view[i, ii];
                }
                arr[i] += '\n';
            }
            return String.Join("", arr);
        }
    }
}
