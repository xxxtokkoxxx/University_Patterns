using Patterns.Strategy_Observer_Command.Citizens;

namespace Patterns.Strategy_Observer_Command.Command;

public class UndoUnitCreationCommand : ICommand
{
    private readonly ICitizen _citizen;

    public UndoUnitCreationCommand(ICitizen citizen)
    {
        _citizen = citizen;
    }

    public void Execute()
    {
        Console.WriteLine($"Delete unit: {_citizen}");
    }
}