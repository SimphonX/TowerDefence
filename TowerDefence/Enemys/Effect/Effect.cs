

using Enemys.Units;
/**
* @(#) Effect.cs
*/
namespace Enemys.Effect
{
	public abstract class Effect
	{
		Enemys.Units.Unit unitHist;

        public Effect(Unit unitHist)
        {
            this.unitHist = unitHist;
        }

        public abstract bool Execute(  );
		
		public bool Undo(  )
		{
            return false;
		}
		
	}
	
}
