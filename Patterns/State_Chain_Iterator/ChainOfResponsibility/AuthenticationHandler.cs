namespace Patterns.State_Chain_Iterator.ChainOfResponsibility;

public class AuthenticationHandler : Handler
{
    protected override string Operation => "Authentication";

    public override void Handle(string operation)
    {
        if (operation == Operation)
        {
            Console.WriteLine("AuthenticationHandler: Request authenticated.");
        }
        else
        {
            Console.WriteLine("AuthenticationHandler: Passing to next.");
            Next.Handle(operation);
        }
    }
}