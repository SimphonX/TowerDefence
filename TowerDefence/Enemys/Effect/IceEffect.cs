

using Enemys.Units;
/**
* @(#) IceEffect.cs
*/
namespace Enemys.Effect
{
	public class IceEffect : Effect
	{
        public IceEffect(Unit unitHist) : base(unitHist)
        {
        }

        public override bool Execute()
        {
            throw new System.NotImplementedException();
        }

        public bool Undo()
        {
            return false;
        }

    }
	
}
