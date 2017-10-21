

using System.Collections.Generic;
/**
* @(#) MinionLeader.cs
*/
public class MinionLeader : MinionPosition
{
	private string name { get; set; }
	
	private List<MinionDecoyUnit> minionDecoys { get; set; }

    private List<MinionFixerUnit> minionFixers { get; set; }

    MinionDecoyUnit Owns;
	
	private int lifepoints { get; set; }

    MinionFixerUnit Owns2;
	
	public void addDecoy( MinionDecoyUnit m )
	{
        minionDecoys.Add(m);

    }
    public void removeDecoy(MinionDecoyUnit M)
    {
        minionDecoys.Remove(M);

    }
    public void addFixer(MinionFixerUnit m)
    {
        minionFixers.Add(m);

    }
    public void removeFixer( MinionFixerUnit M )
	{
        minionFixers.Remove(M);

    }
	
	public void notify(  )
	{
		foreach(MinionFixerUnit m in minionFixers)
        {
            m.SetStatus("FixTower");
        }
        foreach (MinionDecoyUnit m in minionDecoys)
        {
            m.SetStatus("Defence");
        }
    }
	
	public string getName(  )
	{
		return name;
	}
	
	public void setName(string name2)
	{
        name = name2;
	}

     MinionLeader(  )
	{
		
	}
	
}
