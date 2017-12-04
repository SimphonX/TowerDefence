using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class ChatRoom : ChatMediator
    {
        MinionRepository minions=new MinionRepository();
        public override void addMinion(AbstractCloneableMinion minion)
        {
            minions.Add(minion);
        }

        public override void sendMessage(AbstractCloneableMinion sender, string msg)
        {
            for (Iterator iter = minions.getIterator(); iter.hasNext();)
            {
                AbstractCloneableMinion m = (AbstractCloneableMinion)iter.next();
              
                m.receiveMessage(msg);
            }
        }

    }
}
