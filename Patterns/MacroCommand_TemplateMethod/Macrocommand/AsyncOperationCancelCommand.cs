using Patterns.Strategy_Observer_Command.Command;

namespace Patterns.MacroCommand_TemplateMethod.Macrocommand;

public class AsyncOperationCancelCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("asyncoperation cancel");
    }
}