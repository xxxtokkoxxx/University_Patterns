namespace Patterns.Mediator_Interpretator.Interpretator;

public class InterpretatorExample
{
    public void InterpretatorExampleTest()
    {
        CommandParser commandParser = new CommandParser();
        IExpression expression;

        expression = commandParser.Parse(CommandParser.Sethealth, "100");
        expression.Interpret();

        expression = commandParser.Parse(CommandParser.Setlevel, "100");
        expression.Interpret();

        expression = commandParser.Parse(CommandParser.Setmoney, "100");
        expression.Interpret();

        expression = commandParser.Parse(CommandParser.Createdefaultcharacter, "");
        expression.Interpret();
    }
}