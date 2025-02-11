using Patterns.Strategy_Observer_Command.Command;

namespace Patterns.MacroCommand_TemplateMethod.Macrocommand;

public class MacroCommandExample
{
    public void MacroCommandExampleMethod()
    {
        ICommand resourceReleaseCommand = new ResourceReleaseCommand();
        ICommand asyncOperationCancelCommand = new AsyncOperationCancelCommand();
        ICommand userProfileSaveCommand = new UserProfileSaveCommand();

        ICommand macroCommand = new MacroCommand([
            resourceReleaseCommand,
            userProfileSaveCommand,
            asyncOperationCancelCommand
        ]);

        macroCommand.Execute();
    }
}