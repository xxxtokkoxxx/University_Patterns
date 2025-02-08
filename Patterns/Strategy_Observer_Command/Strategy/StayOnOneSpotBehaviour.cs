namespace Patterns.Strategy_Observer_Command.Strategy;

public class StayOnOneSpotBehaviour : IMovementBehaviour
{
    public void DoMovement()
    {
        Console.WriteLine("Staying on the spot");
    }
}