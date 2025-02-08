namespace Patterns.Strategy_Observer_Command.Strategy;

public class OpenToTradeBehaviour : ITradeBehaviour
{
    public void DoTrade()
    {
        Console.WriteLine("Lets make a deal");
    }
}