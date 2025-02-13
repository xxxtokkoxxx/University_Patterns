namespace Patterns.Mediator_Interpretator.Interpretator;

public class CommandParser
{
    public const string Setlevel = "SetLevel";
    public const string Sethealth = "SetHealth";
    public const string Setmoney = "SetMoney";
    public const string Createdefaultcharacter = "CreateDefaultCharacter";

    public IExpression Parse(string command, string amount)
    {
        Context context = new Context(command, amount);
        switch (command)
        {
            case Setlevel:
                return new SetLevelExpression(context);
            case Sethealth:
                return new SetHealthExpression(context);
            case Setmoney:
                return new SetMoneyExpression(context);
            case Createdefaultcharacter:
                return new CreateDefaultCharacterNonTerminal(context);
        }

        throw new Exception("Invalid command: " + command);
    }
}