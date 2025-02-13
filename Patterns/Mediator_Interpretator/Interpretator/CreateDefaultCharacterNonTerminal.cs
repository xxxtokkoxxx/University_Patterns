namespace Patterns.Mediator_Interpretator.Interpretator;

public class CreateDefaultCharacterNonTerminal : IExpression
{
    private SetLevelExpression _setLevelExpression;
    private SetHealthExpression _setHealthExpression;
    private SetMoneyExpression _setMoneyExpression;
    private Context _context;

    public CreateDefaultCharacterNonTerminal(Context context)
    {
        _context = context;
        _setLevelExpression = new SetLevelExpression(new Context(CommandParser.Setlevel, "1"));
        _setHealthExpression = new SetHealthExpression(new Context(CommandParser.Setlevel, "100"));
        _setMoneyExpression = new SetMoneyExpression(new Context(CommandParser.Setlevel, "50"));
    }

    public void Interpret()
    {
        _setLevelExpression.Interpret();
        _setHealthExpression.Interpret();
        _setMoneyExpression.Interpret();

        Console.WriteLine("Create default character");
    }
}