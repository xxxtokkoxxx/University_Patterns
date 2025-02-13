namespace Patterns.Mediator_Interpretator.Interpretator;

public class SetLevelExpression : IExpression
{
    private readonly Context _context;

    public SetLevelExpression(Context context)
    {
        _context = context;
    }

    public void Interpret()
    {
        Console.WriteLine($"Set level to character: {_context.Amount}");
    }
}