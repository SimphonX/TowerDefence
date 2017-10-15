

using Enemys.Units;
/**
* @(#) Effect.cs
*/
namespace Enemys.Effect
{
	public abstract class Effect
	{
		Unit unit;
        public Unit Unit { get => unit; set => unit = value; }
        public Effect(Unit unit)
        {
            this.unit = unit;
        }

        public abstract bool Execute(  );
		
		public virtual void Undo(  )
		{
		}
		
	}
	
}
