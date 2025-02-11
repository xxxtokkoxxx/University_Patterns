namespace Patterns.MacroCommand_TemplateMethod.Template;

public class CryptoPayment : PaymentProcessor
{
    protected override void ValidatePayment()
    {
        Console.WriteLine($"{nameof(CryptoPayment)} validated");
    }

    protected override void ExecuteTransaction()
    {
        Console.WriteLine($"{nameof(CryptoPayment)} executed");
    }
}