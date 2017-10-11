namespace Enemys.Units
{
	public class NormalUnit : Unit
	{
        public NormalUnit(int level)
        {
            this.Gold = 3;
            this.HP = 20;
            this.Name = "Normal";
            this.Speed = 5;
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
