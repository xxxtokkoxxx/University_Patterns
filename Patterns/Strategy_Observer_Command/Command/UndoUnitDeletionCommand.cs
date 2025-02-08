using Patterns.Strategy_Observer_Command.Citizens;

namespace Patterns.Strategy_Observer_Command.Command;

public class UndoUnitDeletionCommand : ICommand
{
    private readonly ICitizen _citizen;

    public UndoUnitDeletionCommand(ICitizen citizen)
    {
        _citizen = citizen;
    }

    public void Execute()
    {
        Console.WriteLine($"Create unit: {_citizen}");
    }
}