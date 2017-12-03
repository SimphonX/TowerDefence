using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class NullObjectMinion : AbstractCloneableMinion
    {
        public override void dismiss()
        {
            throw new NotImplementedException();
        }

        public override int getLifepoints()
        {
            return 0;
        }

        public override string getName()
        {
            return "";
        }

        public override string getStatus()
        {
            return "";
        }

        public override void receiveCommand(string command)
        {
            return;
        }

        public override void respawn(int x, int y)
        {
            return;
        }

        public override void setLifepoints(int points)
        {
            lifepoints = 0;
        }

        public override void setMinionLeader(AbstractMinionLeader minionLeader)
        {
            return;
        }

        public override void setName(string name)
        {
            return;
        }

        public override void SetStatus(string status)
        {
            return;
        }
    }
}
