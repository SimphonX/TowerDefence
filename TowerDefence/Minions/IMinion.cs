/**
 * @(#) IMinion.cs
 */

public interface IMinion
{
	void setMinionLeader( AbstractMinionLeader minionLeader );
	
	void receiveCommand( string command );
	
}
