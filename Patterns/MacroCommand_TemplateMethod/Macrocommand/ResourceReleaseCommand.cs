using Patterns.Strategy_Observer_Command.Command;

namespace Patterns.MacroCommand_TemplateMethod.Macrocommand;

public class ResourceReleaseCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("resource release");
    }
}