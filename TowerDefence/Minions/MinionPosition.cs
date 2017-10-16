/**
 * @(#) MinionPosition.cs
 */

public abstract class MinionPosition
{
	private int CoordinateX;
	
	private int CoordinateY;
	
	public virtual int getCoordinateX(  )
	{
		return CoordinateX;
	}
	
	public virtual int getCoordinateY(  )
	{
		return CoordinateY;
	}
	
	public virtual void setCoordinateX(int coordx  )
	{
        CoordinateX = coordx;
	}
	
	public virtual void setCoordinateY(int coordy )
	{
        CoordinateY = coordy;
	}
	
}
