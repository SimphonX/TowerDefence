namespace Enemys.Units.Behavior
{
    public class Rush : IUnitBehaviour

    {
        public void Attack(  )
        {
            System.Console.Write("Attack weak point\n");
        }

        public void Move(  )
        {
            System.Console.Write("Move to weak point\n");
        }
    }

}
