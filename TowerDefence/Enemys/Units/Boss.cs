namespace Enemys.Units
{	
	public class Boss : Unit
	{
		public Boss(int level)
		{
            this.Gold = 10;
            this.HP = 50;
            this.Name = "Boss";
            this.Speed = 3;
            this.Timer = 1;
		}
        public override void Stop() => Speed = 0;
        public override void Slow() => Speed /= 2;
        public override void TakeDamage(int dmg)
        {
            HP -= dmg;
        }

        public override void KnockBack()
        {
            
        }

        public override int DropGold => Gold;
    }
	
}
