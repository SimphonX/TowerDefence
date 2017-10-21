

using System;
using TowerDefence.Minions;
/**
* @(#) MinionFixerUnit.cs
*/
public class MinionFixerUnit : AbstractCloneableMinion
{

    private MinionFixerBoss Boss;

    public bool fixTower(string command, int x=0, int y=0 )
	{
        if(command=="StartFixing")
        Console.WriteLine("["+this.name+"]"+DateTime.Now.ToString()+":" + " Started fixing at x: "+x.ToString()+" y: "+y.ToString() );

        return true;
	}
	
	public MinionFixerUnit( string name, int lifepoints, string status, MinionFixerBoss ml )
	{
        setName(name);
        setLifepoints(lifepoints);
        SetStatus(status);
        setMinionLeader(ml);
 
    }
   

    public override void receiveCommand(string command)
    {
        Console.WriteLine("["+this.name + "]" + DateTime.Now.ToString() + ":" + " received command : " +command);
        SetStatus(command);
        switch(command)
        {
                case "StartFixing":
                fixTower(command);
                break;

                case "FinishWork":
                dismiss();
                break;
        }
    }

    public override void dismiss()
    {
        Console.WriteLine("["+this.name + "]" + DateTime.Now.ToString() + ":" + " finishing my job");
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
        Console.WriteLine("Hello my name is " + this.name + " I am fixer, my status is " + this.status);
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
        Console.WriteLine("["+this.name + "]" + DateTime.Now.ToString() + ":" + "  respawning ");
        this.setLifepoints(100);
        this.SetStatus("Ready");
    }


    public override void setMinionLeader(AbstractMinionLeader minionLeader)
    {
        Boss = (MinionFixerBoss)minionLeader;
        Console.WriteLine("[" + this.name+"]" + DateTime.Now.ToString() + ":" + "  my boss is " +Boss.getName());
    }

}
