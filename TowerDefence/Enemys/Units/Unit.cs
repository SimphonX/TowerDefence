using Enemys.Units.Behavior;
using Audio;
using System.IO;

namespace Enemys.Units
{
    public abstract class Unit
    {
        private int hP;

        private string name;

        private int speed;

        private int gold;

        private int timer;

        private int x, y;

        private Sound sound = new EnemyUnitSoundAdapter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+"\\Resurses\\hit.mp3");

        IUnitBehaviour behaviour;
        
        public int HP { get => hP; set => hP = value; }
        public string Name { get => name; set => name = value; }
        public int Timer { get => timer; set => timer = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Speed { get => speed; set => speed = value; }
        public IUnitBehaviour Behaviour { get => behaviour; set => behaviour = value; }
        public Sound Sound { get => sound; set => sound = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void Move()
        {
            behaviour.Move();
        }

        public void Attack()
        {
            Sound.PlaySound();
            Behaviour.Attack();
        }
        public abstract bool Stop();
        public abstract bool Slow();
        public abstract void TakeDamage(int dmg);
        public abstract int DropGold();
        public abstract bool KnockBack();
    }

}