namespace Enemys.Units
{
	public class TankUnit : Unit
	{
        public TankUnit(int level)
        {
            this.Gold = 5;
            this.HP = 35;
            this.Name = "Tank";
            this.Speed = 2;
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