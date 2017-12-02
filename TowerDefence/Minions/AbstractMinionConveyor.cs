using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Minions
{
    public abstract class AbstractMinionConveyor
    {
       protected AbstractCloneableMinion minion;
        public AbstractCloneableMinion BuildMinion(string minionType,string name, int lifepoints,string status,AbstractMinionLeader ml)
        {
            switch(minionType)
            {
                case "Fixer":
                    {
                        minion = new MinionFixerUnit(name, lifepoints, status, (MinionFixerBoss)ml);
                        break;
                    }
                case "StandingDecoy":
                    {
                        minion = new MinionStandingDecoyUnit(name, lifepoints, status, (MinionDecoyBoss)ml);
                        break;
                    }
                    
                case "MovingDecoy":
                    {
                        minion = new MinionMovingDecoyUnit(name, lifepoints, status, (MinionDecoyBoss)ml);
                        break;
                    }
            }
            makeBody();
            if (needHands())
            {
                addHands();
            }
            if (needLegs())
            {
                addLegs();
            }
            if (needRollerBlades())
            {
                addRollerblades();
            }
            if (needShield())
            {
                addShield();
            }
            if(needTools())
            {
                addTools();
            }
            return minion;
        }

        public void makeBody()
        {
            minion.addAtribute("Body");
            Console.WriteLine("[" + minion.getName() + "]" + DateTime.Now.ToString() + ": Body added");
        }
        public void addHands()
        {
            minion.addAtribute("Hands");
            Console.WriteLine("[" + minion.getName() + "]" + DateTime.Now.ToString() + ": Hands added");
        }
        public abstract void addShield();
        public abstract void addRollerblades();
        public abstract void addTools();
        public void addLegs()
        {
            minion.addAtribute("Legs");
            Console.WriteLine("[" + minion.getName() + "]" + DateTime.Now.ToString() + ": Legs added");

        }
        public bool needHands()
        {
            return true;
        }
        public bool needLegs()
        { return true; }
        public abstract bool needShield();

        public abstract bool needRollerBlades();
        public abstract bool needTools();
    }
}
