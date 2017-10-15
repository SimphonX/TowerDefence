

using Enemys.Units;
/**
* @(#) IceEffect.cs
*/
namespace Enemys.Effect
{
	public class IceEffect : Effect
	{
        int copy;
        public IceEffect(Unit unitHist) : base(unitHist)
        {
        }

        public override bool Execute()
        {
            copy = Unit.Speed;
            return Unit.Slow();
        }

        public override void Undo()
        {
            Unit.Speed = copy;
            System.Console.WriteLine("Speed restore to " + Unit.Speed);
        }

    }
	
}
