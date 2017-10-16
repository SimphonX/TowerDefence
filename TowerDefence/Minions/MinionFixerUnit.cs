

using System;
/**
* @(#) MinionFixerUnit.cs
*/
public class MinionFixerUnit : AbstractCloneableMinion
{

    private int lifepoints;

    private string status;
    private String name;


    private MinionLeader IsControlledBy2;
	
	public bool fixTower( int x, int y )
	{
		return true;
	}
	
	internal MinionFixerUnit( string name, int lifepoints, string status )
	{
		
	}
   

    public override void receiveCommand(string command)
    {
        throw new NotImplementedException();
    }

    public override void dismiss()
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public override int getPositionX()
    {
        throw new NotImplementedException();
    }

    public override void setMinionLeader(MinionLeader minionLeader)
    {
        IsControlledBy2 = minionLeader;
    }


    public override AbstractCloneableMinion Clone()
    {
        return (MinionFixerUnit)this.MemberwiseClone();
    }
}
