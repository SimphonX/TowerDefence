using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Main
{
    public abstract class RequestHandler
    {
        protected RequestHandler next;
   

        public abstract void ExecuteModule(string Request);

        public abstract void setNextChain(RequestHandler next);
    }
}
