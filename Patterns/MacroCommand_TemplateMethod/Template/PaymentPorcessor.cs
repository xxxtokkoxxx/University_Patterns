namespace Patterns.MacroCommand_TemplateMethod.Template;

public abstract class PaymentProcessor
{
    public void ProcessPayment()
    {
        ValidatePayment();
        ExecuteTransaction();
        SendConfirmation();
    }

    protected abstract void ValidatePayment();
    protected abstract void ExecuteTransaction();

    private void SendConfirmation()
    {
        Console.WriteLine("The payment has been successfully sent");
    }
}