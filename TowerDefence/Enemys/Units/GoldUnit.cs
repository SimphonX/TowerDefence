using System;

namespace Enemys.Units
{
	public class GoldUnit : Unit
	{
        Random ran = new Random();
        public GoldUnit(int level)
        {
            this.Gold = 10;
            this.HP = 1;
            this.Name = "Gold";
            this.Speed = 3;
            this.Timer = 1;
        }
        public override bool Stop()
        {
            if (ran.Next(1, 99) > 35) return false;
            Console.WriteLine(Name + " stoped moving");
            Speed = 0;
            return true;
        }
        public override bool Slow()
        {
            if (Stop()) return true;
            if (ran.Next(1, 99) > 70) return false;
            Console.WriteLine(Name + " slowed down");
            Speed /= 2;
            return true;
        }
        public override void TakeDamage(int dmg)
        {
            HP -= dmg;
        }

        public override bool KnockBack()
        {
            if (ran.Next(1, 99) > 60) return false;
            Console.WriteLine(Name + " knocked back");
            return true;
        }

        public override int DropGold()
        {
            return Gold;
        }
    }
	
}
