

using System;
/**
* @(#) AbstractCloneableMinion.cs
*/
public abstract class AbstractCloneableMinion : AbstractMinionPosition, ICloneable, IMinion
{

    protected String name;

    protected int lifepoints=100;

    protected String status="Ready";

    protected int respawntime=10;


    public abstract void dismiss();


    public abstract String getName();

    public abstract int getLifepoints();

    public abstract String getStatus();

    public abstract void setName(String name);

    public abstract void setLifepoints(int points);

    public abstract void SetStatus(String status);

    public abstract void respawn(int x, int y);

    public AbstractCloneableMinion createClone()
    {
        Console.WriteLine("Creating minion Clone");
        return (AbstractCloneableMinion)this.MemberwiseClone();
    }

    public abstract void setMinionLeader(AbstractMinionLeader minionLeader);


    public abstract void receiveCommand(string command);

    object ICloneable.Clone()
    {
        return (AbstractCloneableMinion)this.MemberwiseClone();
    }
}
