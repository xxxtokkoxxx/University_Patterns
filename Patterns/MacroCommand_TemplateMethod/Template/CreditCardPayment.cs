namespace Patterns.MacroCommand_TemplateMethod.Template;

public class CreditCardPayment : PaymentProcessor
{
    protected override void ValidatePayment()
    {
        Console.WriteLine($"{nameof(CreditCardPayment)} validated");
    }

    protected override void ExecuteTransaction()
    {
        Console.WriteLine($"{nameof(CreditCardPayment)} executed");
    }
}