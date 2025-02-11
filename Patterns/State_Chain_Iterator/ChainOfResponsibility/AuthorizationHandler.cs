namespace Patterns.State_Chain_Iterator.ChainOfResponsibility;

public class AuthorizationHandler : Handler
{
    protected override string Operation => "Authorization";

    public override void Handle(string operation)
    {
        if (operation == Operation)
        {
            Console.WriteLine("AuthorizationHandler: User authorized.");
        }
        else
        {
            Console.WriteLine("AuthorizationHandler: Passing to next.");
            Next?.Handle(operation);
        }
    }
}