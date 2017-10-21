using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public class MinionMovingDecoyUnit : AbstractCloneableMinion
    {
        private MinionDecoyBoss Boss;

      public MinionMovingDecoyUnit(string name, int lifepoints, string status, MinionDecoyBoss ml)
        {
            setName(name);
            setLifepoints(lifepoints);
            SetStatus(status);
            setMinionLeader(ml);
  
        }

        public override void dismiss()
        {
            Console.WriteLine("[" + this.name+"]" + DateTime.Now.ToString() + ":" + " finishing my job");
        }

        public override int getLifepoints()
        {
            return lifepoints;
        }

        public override string getName()
        {
            return name;
        }

        public override string getStatus()
        {
            return status;
        }
        public void startMoving()
        {
            Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + " started defending");
        }
        public override void receiveCommand(string command)
        {
            Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + " received command : " + command);
            SetStatus(command);
            switch (command)
            {
                case "StartDefending":
                    startMoving();
                    break;

                case "FinishWork":
                    dismiss();
                    break;
            }
        }

        public override void respawn(int x, int y)
        {
            Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + "  respawning ");
            this.setLifepoints(100);
            this.SetStatus("Ready");
        }

        public override void setLifepoints(int points)
        {
            lifepoints = points;
        }

        public override void setMinionLeader(AbstractMinionLeader minionLeader)
        {
            Boss = (MinionDecoyBoss)minionLeader;
            Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + "  my boss is " + Boss.getName());
        }

        public override void setName(string namex)
        {
            name = namex;
            Console.WriteLine("Hello my name is " + this.name + " I am moving decoy, my status is " + this.status);
        }

        public override void SetStatus(string status2)
        {
            status = status2;
        }
    }
}
