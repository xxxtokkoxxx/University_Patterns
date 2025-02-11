namespace Patterns.MacroCommand_TemplateMethod.Template;

public class PayPalPayment : PaymentProcessor
{
    protected override void ValidatePayment()
    {
        Console.WriteLine($"{nameof(PayPalPayment)} validated");
    }

    protected override void ExecuteTransaction()
    {
        Console.WriteLine($"{nameof(PayPalPayment)} executed");
    }
}