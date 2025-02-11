namespace Patterns.State_Chain_Iterator.ChainOfResponsibility;

public class LoggingHandler : Handler
{
    protected override string Operation => "Login";

    public override void Handle(string operation)
    {
        Console.WriteLine("LoggingHandler: Request logged.");
        Next?.Handle(operation);
    }
}