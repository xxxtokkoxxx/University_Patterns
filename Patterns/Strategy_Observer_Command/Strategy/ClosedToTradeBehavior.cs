namespace Patterns.Strategy_Observer_Command.Strategy;

public class ClosedToTradeBehavior : ITradeBehaviour
{
    public void DoTrade()
    {
        Console.WriteLine("I dont trade");
    }
}