

using System;

using System.Collections.Generic;
using TowerDefence.Minions;
/**
* @(#) AbstractCloneableMinion.cs
*/
public abstract class AbstractCloneableMinion : AbstractMinionPosition, ICloneable, IMinion
{

    protected String name;

    protected int lifepoints=100;

    protected String status="Ready";

    protected int respawntime=10;

    protected ChatMediator mediator;

    protected List<string> attributes = new List<string>();
    public abstract void dismiss();
    public void send(string message)
    {
        Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + " sent message: " + message);
        if(mediator != null)
        {
            mediator.sendMessage(this, message);
        }
    }
    public void receiveMessage(string message)
    {
        Console.WriteLine("[" + this.name + "]" + DateTime.Now.ToString() + " received message: " + message);
    }



    public void addAtribute(string attribute)
    {
        attributes.Add(attribute);
    }
    public List<string> getAtributes()
    {
        return attributes;
    }

    public abstract String getName();

    public abstract int getLifepoints();

    public abstract String getStatus();

    public abstract void setName(String name);

    public abstract void setLifepoints(int points);

    public abstract void SetStatus(String status);
    public void setMediator(ChatMediator CM)
    {
        mediator = CM;
    }

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
