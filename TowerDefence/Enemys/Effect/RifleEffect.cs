

using Enemys.Units;
/**
* @(#) RifleEffect.cs
*/
namespace Enemys.Effect
{
	public class RifleEffect : Effect
	{
        public RifleEffect(Unit unitHist) : base(unitHist)
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
