

using System;
/**
* @(#) AbstractCloneableMinion.cs
*/
public abstract class AbstractCloneableMinion : MinionPosition, ICloneable, IMinion
{
	String name;
	
	int lifepoints;
	
	String status;

    public abstract AbstractCloneableMinion Clone();


    public abstract void dismiss();


    public abstract String getName();

    public abstract int getLifepoints();

    public abstract String getStatus();

    public abstract void setName(String name);

    public abstract void setLifepoints(int points);

    public abstract void SetStatus(String status);

    public abstract void respawn(int x, int y);

    public abstract int getPositionX();



    public abstract void setMinionLeader(MinionLeader minionLeader);



    object ICloneable.Clone()
    {
        throw new NotImplementedException();
    }

    public abstract void receiveCommand(string command);
}
