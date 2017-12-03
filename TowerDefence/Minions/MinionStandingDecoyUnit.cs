

using System;
using TowerDefence.Minions;
/**
* @(#) MinionDecoyUnit.cs
*/
public class MinionStandingDecoyUnit : AbstractCloneableMinion
{

    private MinionDecoyBoss Boss;


   public MinionStandingDecoyUnit(string name, int lifepoints, string status, MinionDecoyBoss ml,ChatMediator CM)
    {
        setName(name);
        setLifepoints(lifepoints);
        SetStatus(status);
        setMediator(CM);
        setMinionLeader(ml);
    }
    public void moveToPoint(int x, int y)
    {
        Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + " started defending");
    }

    public override void dismiss()
    {
        Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + " finishing my job");
    }

    public override string getName()
    {
        return name;
    }

    public override int getLifepoints()
    {
        return lifepoints;
    }

    public override string getStatus()
    {
        return status;
    }

    public override void setName(string namex)
    {
      
        name = namex;
        Console.WriteLine("Hello my name is " + this.name + " I am standing decoy, my status is " + this.status);
    }

    public override void setLifepoints(int points)
    {
        lifepoints = points;
    }

    public override void SetStatus(string status2)
    {
        status = status2;
    }

    public override void respawn(int x, int y)
    {
        Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + "  respawning ");
        this.setLifepoints(100);
        this.SetStatus("Ready");
    }


    public override void setMinionLeader(AbstractMinionLeader minionLeader)
    {
        Boss = (MinionDecoyBoss)minionLeader;
    }

    public override void receiveCommand(string command)
    {
        Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + ":" + " received command : " + command);
        SetStatus(command);
        switch (command)
        {
            case "StartDefending":
                moveToPoint(0, 0);
                break;

            case "FinishWork":
                dismiss();
                break;
        }
    }
}

