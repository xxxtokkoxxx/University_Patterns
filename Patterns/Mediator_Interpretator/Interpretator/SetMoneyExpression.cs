namespace Patterns.Mediator_Interpretator.Interpretator;

public class SetMoneyExpression : IExpression
{
    private readonly Context _context;

    public SetMoneyExpression(Context context)
    {
        _context = context;
    }

    public void Interpret()
    {
        Console.WriteLine($"Set money to character: {_context.Amount}");
    }
}