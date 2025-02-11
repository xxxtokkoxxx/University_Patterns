using Patterns.Strategy_Observer_Command.Command;

namespace Patterns.MacroCommand_TemplateMethod.Macrocommand;

public class UserProfileSaveCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("user profile save");
    }
}