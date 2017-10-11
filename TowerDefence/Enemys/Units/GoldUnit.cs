namespace Enemys.Units
{
	public class GoldUnit : Unit
	{
        public GoldUnit(int level)
        {
            this.Gold = 10;
            this.HP = 1;
            this.Name = "Gold";
            this.Speed = 3;
            this.Timer = 1;
        }
    }
	
}
