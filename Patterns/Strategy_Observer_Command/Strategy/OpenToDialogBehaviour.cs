namespace Patterns.Strategy_Observer_Command.Strategy;

public class OpenToDialogBehaviour : IDialogBehaviour
{
    public void DoDialog()
    {
        Console.WriteLine("Hello, how can I help you?");
    }
}