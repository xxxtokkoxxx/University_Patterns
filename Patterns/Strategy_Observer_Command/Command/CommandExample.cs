using Patterns.Strategy_Observer_Command.Citizens;
using Patterns.Strategy_Observer_Command.Strategy;

namespace Patterns.Strategy_Observer_Command.Command;

public class CommandExample
{
    private Queue<ICommand> _commands = new();

    public void CommandsExample()
    {
        ICitizen citizen = new GuardianCitizen(new PatrolongtBehaviour(), new OpenToDialogBehaviour(),
            new ClosedToTradeBehavior());
        Console.WriteLine($"Create citizen: {citizen}");
        _commands.Enqueue(new UndoUnitCreationCommand(citizen));

        ICitizen temp = citizen;
        citizen = null;

        _commands.Enqueue(new UndoUnitDeletionCommand(temp));
        Console.WriteLine($"Delete citizen: {temp}");
        Console.WriteLine($"Undo deletion command");
        ICommand undoDeletionCommand = _commands.Dequeue();
        undoDeletionCommand.Execute();

        Console.WriteLine($"Undo creation command");
        ICommand undoCreationCommand = _commands.Dequeue();
        undoCreationCommand.Execute();
    }
}