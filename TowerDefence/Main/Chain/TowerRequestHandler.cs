using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Main.ChainOfResponsibilities
{
    public class TowerRequestHandler : RequestHandler
    {
        public override void ExecuteModule(string Request)
        {
            if (Request == "TowersStart")
            {
              
                Console.ForegroundColor = System.ConsoleColor.Yellow;
                TowersDemo.run();
            }
            else { next.ExecuteModule(Request); }
        }

        public override void setNextChain(RequestHandler next)
        {
            this.next = next;
        }
    }
}
