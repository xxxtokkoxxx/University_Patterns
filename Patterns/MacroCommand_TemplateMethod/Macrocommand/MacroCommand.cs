using Patterns.Strategy_Observer_Command.Command;

namespace Patterns.MacroCommand_TemplateMethod.Macrocommand;

public class MacroCommand : ICommand
{
    private readonly List<ICommand> _commands;

    public MacroCommand(List<ICommand> commands)
    {
        _commands = commands;
    }

    public void Execute()
    {
        foreach (ICommand command in _commands)
        {
            command.Execute();
        }
    }
}