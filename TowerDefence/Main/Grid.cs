using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using towers_classes;

namespace TowerDefence.Main
{
    public class Grid
    {
        private int gridXSize;
        private int gridYSize;
        private ExistingItem[,] grid;
        private Dictionary<string,string> itemDictionary;
        //dictionary example: key->value, "LaserTower"->"l"
        //as in what string letter represents what class, 
        //the key will be looked up by .GetType().Name which gives
        //the mentioned classes name, so make sure to specify

        public Grid(int xSize, int ySize, Dictionary<string,string> items)
        {
            this.grid = new ExistingItem[ySize, xSize]; this.itemDictionary = items;
        }

        public bool appendDictionary(string key, string letter)
        {
            if (itemDictionary.ContainsKey(key))
            {
                return false;
            }
            else
            {
                itemDictionary.Add(key, letter);
                return true;
            }
        }

        public bool populate(int x, int y, ExistingItem item)
        {
            if (grid[y, x] == null)
            {
                grid[y, x] = item;
                return true;
            }
            else return false;
        }

        public string getInfo(int x, int y)
        {
            string result = "";
            if (grid[y,x] != null)
            {
                result = grid[y, x].GetType().Name;
            }
            return result;
        }

        public string[] drawGrid()//returns map in lines
        {
            string[] arr = new string[grid.GetLength(0)];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int ii = 0; ii < grid.GetLength(1); ii++)
                {
                    if (grid[i, ii] != null)//if that element is initialized
                    {
                        string letter = "";
                        if(itemDictionary.TryGetValue(grid[i,ii].GetType().Name,out letter))//if it has an entry in dictionary
                        {
                            arr[i] += letter;
                        }
                        else
                        {
                            arr[i] += " ";
                        }
                        
                    }
                    else
                    {

                        arr[i] += " ";
                    }
                        
                }
            }
            return arr;
        }
    }
}
