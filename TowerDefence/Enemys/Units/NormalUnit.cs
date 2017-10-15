using System;

namespace Enemys.Units
{
	public class NormalUnit : Unit
	{
        Random ran = new Random();
        public NormalUnit(int level)
        {
            this.Gold = 3;
            this.HP = 20;
            this.Name = "Normal";
            this.Speed = 5;
            this.Timer = 1;
        }
        public override bool Stop()
        {
            if (ran.Next(1, 99) > 30) return false;
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
            if (ran.Next(1, 99) > 50) return false;
            Console.WriteLine(Name + " knocked back");
            return true;
        }

        public override int DropGold()
        {
            return Gold;
        }
    }
	
}
