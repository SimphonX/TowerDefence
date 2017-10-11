namespace Enemys.Units
{
	public class SpeedUnit : Unit
	{
        public SpeedUnit(int level)
        {
            this.Gold = 5;
            this.HP = 15;
            this.Name = "Speed";
            this.Speed = 8;
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
