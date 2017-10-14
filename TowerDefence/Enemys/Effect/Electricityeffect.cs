

using Enemys.Units;
/**
* @(#) Electricityeffect.cs
*/
namespace Enemys.Effect
{
	public class Electricityeffect : Effect
	{
        public Electricityeffect(Unit unitHist) : base(unitHist)
        {
        }

        public override bool Execute()
        {
            throw new System.NotImplementedException();
        }

        public bool Undo(  )
		{
			return false;
		}
		
	}
	
}
