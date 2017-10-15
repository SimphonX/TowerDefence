/**
 * @(#) IMinion.cs
 */

public interface IMinion
{
	void setMinionLeader( MinionLeader minionLeader );
	
	void receiveCommand( string command );
	
}
