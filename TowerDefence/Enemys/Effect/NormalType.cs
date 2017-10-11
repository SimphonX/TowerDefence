using Enemys.Units;
using System;

namespace Enemys.Effect
{
    public class NormalType : TowerEffect
    {
        Unit Units;
        Random sk = new Random();

        public Unit Units1 { get => Units; set => Units = value; }

        public NormalType(Unit unit)
        {
            Units = unit;
        }

        public void ElectricityEffect()
        {
            if (sk.Next(1, 99) < 30) StunEffect();
        }

        public void IceEffect()
        {
            if (sk.Next(1, 99) < 30) FreezeEffect();
            else if (sk.Next(1, 99) < 70) SlowEffect();
        }

        public void RifleEffect()
        {
            if (sk.Next(1, 99) < 50) KnockBack();
        }
        private void StunEffect()
        {
            Units.Stop();
            Console.WriteLine(Units.Name + " stuned");
        }
        private void SlowEffect()
        {
            Units.Slow();
            Console.WriteLine(Units.Name + " slowed");
        }
        private void FreezeEffect()
        {
            Units.Stop();
            Console.WriteLine(Units.Name + " freezed");
        }
        private void KnockBack()
        {
            Units.KnockBack();
            Console.WriteLine(Units.Name + " knocked back");
        }
    }
}