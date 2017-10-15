

using Enemys.Units;
/**
* @(#) Electricityeffect.cs
*/
namespace Enemys.Effect
{
	public class Electricityeffect : Effect
	{
        int copy;
        public Electricityeffect(Unit unitHist) : base(unitHist)
        {
        }

        public override bool Execute()
        {
            copy = Unit.Speed;
            return Unit.Stop();
        }

        public override void Undo(  )
		{
            Unit.Speed = copy;
            System.Console.WriteLine("Speed restore to "+Unit.Speed);
		}
		
	}
	
}
