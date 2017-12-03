

using System;
/**
* @(#) Caretaker.cs
*/
namespace towers_classes
{
	public class Caretaker
	{
        private Memento backup;
        private AbstractTower tower;

        public Caretaker( AbstractTower tower )
        {
            this.tower = tower;
        }

        public void backupState( )
        {
            backup = tower.backupState();
        }

        public void restoreState( )
        {
            if (backup != null)
            {
                Console.WriteLine("Restoring tower's " + this.tower.GetType().Name + " state");
                backup.restore();
            }
        }
	}
	
}
