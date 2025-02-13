namespace Patterns.Mediator_Interpretator.Interpretator;

public class SetHealthExpression : IExpression
{
    private readonly Context _context;

    public SetHealthExpression(Context context)
    {
        _context = context;
    }

    public void Interpret()
    {
        Console.WriteLine($"Set health to character: {_context.Amount}");
    }
}