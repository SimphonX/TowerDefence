using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
   public abstract class ChatMediator
    {
        public abstract void sendMessage(AbstractCloneableMinion sender, string msg);
        public abstract void addMinion(AbstractCloneableMinion minion);
    }
}
