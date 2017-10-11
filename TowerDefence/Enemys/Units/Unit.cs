using Enemys.Units.Behavior;
using Audio;

namespace Enemys.Units
{
    public abstract class Unit
    {
        private int hP;

        private string name;

        private int speed;

        private int gold;

        private int timer;

        private Sound sound = new EnemyUnitSoundAdapter();

        IUnitBehaviour behaviour;
        
        public int HP { get => hP; set => hP = value; }
        public string Name { get => name; set => name = value; }
        public int Timer { get => timer; set => timer = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Speed { get => speed; set => speed = value; }
        public IUnitBehaviour Behaviour { get => behaviour; set => behaviour = value; }
        public Sound Sound { get => sound; set => sound = value; }

        public void Move()
        {
            behaviour.Move();
        }

        public void Attack()
        {
            Behaviour.Attack();
        }
    }

}