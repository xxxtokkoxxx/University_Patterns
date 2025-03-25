namespace Patterns.Facade_Proxy_Bridge.Decorator;

public class DecoratorExample
{
    public void Test()
    {
        InitialDecorator initialDecorator = new InitialDecorator();
        ColorEffectDecorator colorEffectDecorator = new ColorEffectDecorator(initialDecorator);
        SizeEffectDecorator sizeEffectDecorator = new SizeEffectDecorator(colorEffectDecorator);

        sizeEffectDecorator.ApplyEffect();
    }
}