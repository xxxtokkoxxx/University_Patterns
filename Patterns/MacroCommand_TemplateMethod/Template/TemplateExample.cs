namespace Patterns.MacroCommand_TemplateMethod.Template;

public class TemplateExample
{
    public void TemplateExampleMethod()
    {
        PaymentProcessor cryptoPayment = new CryptoPayment();
        PaymentProcessor paymentProcessor = new PayPalPayment();
        PaymentProcessor creditCardPayment = new CreditCardPayment();

        cryptoPayment.ProcessPayment();
        paymentProcessor.ProcessPayment();
        creditCardPayment.ProcessPayment();
    }
}