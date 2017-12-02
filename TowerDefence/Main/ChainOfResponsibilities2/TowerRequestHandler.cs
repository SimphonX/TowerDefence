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
            Console.BackgroundColor = System.ConsoleColor.Yellow;
        }

        public override void setNextChain(RequestHandler next)
        {
            this.next = next;
        }
    }
}
