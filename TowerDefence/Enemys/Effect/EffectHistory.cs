

using System.Collections.Generic;
/**
* @(#) EffectHistory.cs
*/
namespace Enemys.Effect
{
	public class EffectHistory
	{
		List<Effect> unitList = new List<Effect>();
		
		public void AddEffect(Effect effect)
		{
            unitList.Add(effect);
		}
		
		public void UndoEffect(  )
		{
            if (unitList.Count == 0) return;
            unitList[unitList.Count-1].Undo();
            unitList.RemoveAt(unitList.Count-1);
		}
        public void UndoEffect(Effect effect)
        {
            effect.Undo();
            unitList.Remove(effect);
        }

    }
	
}
