

using System.Collections.Generic;
using TowerDefence.Minions;
using towers_classes;
/**
* @(#) MinionLeader.cs
*/
public abstract class AbstractMinionLeader : AbstractMinionPosition
{
    protected string name;

    protected MinionRepository minions;

    protected int lifepoints;

    protected List<AbstractTower> towers;

    public abstract void addMinion(AbstractCloneableMinion m);
    public abstract void removeMinion(AbstractCloneableMinion M);

    public abstract int getTowerWithLeastLp();

    public abstract void notify();

    public string getName()
    {
        return name;
    }

    public int getlifepoints()
    {
        return lifepoints;
    }
    public void setlifepoints(int lp)
    {
        lifepoints = lp;
    }
    public void setName(string name2)
    {
        name = name2;
    }



}
