

using System;
/**
* @(#) MinionDecoyUnit.cs
*/
public class MinionDecoyUnit : AbstractCloneableMinion
{


   private String name;

   private int lifepoints;

   private  String status;

   private  MinionLeader IsControlledBy;
	
	public void moveToPoint( int x, int y )
	{
		
	}

    public override AbstractCloneableMinion Clone()
    {
        return (MinionDecoyUnit)this.MemberwiseClone();
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
        IsControlledBy = minionLeader;
    }

    public override void receiveCommand(string command)
    {
        throw new NotImplementedException();
    }

    MinionDecoyUnit( string name, int lifepoints, string status,MinionLeader ML )
	{
        setName(name);
        SetStatus(status);
        setLifepoints(lifepoints);
        setMinionLeader(ML);
	}
	
}
