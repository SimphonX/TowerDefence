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
        public override void Stop()
        {
            Speed = 0;
        }
        public override void Slow()
        {
            Speed /= 2;
        }
        public override void TakeDamage(int dmg)
        {
            HP -= dmg;
        }

        public override void KnockBack()
        {

        }

        public override int DropGold()
        {
            return Gold;
        }
    }
	
}
