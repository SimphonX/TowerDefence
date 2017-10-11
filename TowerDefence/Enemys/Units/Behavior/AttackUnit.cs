namespace Enemys.Units.Behavior
{
    public class AttackUnit : IUnitBehaviour
    {
        public void Attack(  )
        {
            System.Console.Write("Attack Minion\n");
        }

        public void Move(  )
        {
            System.Console.Write("Move To minion\n");
        }
    }

}
