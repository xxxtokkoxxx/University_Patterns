namespace Patterns.Strategy_Observer_Command.Strategy;

public class PatrolongtBehaviour : IMovementBehaviour
{
    public void DoMovement()
    {
        Console.WriteLine("Patrolling city");
    }
}