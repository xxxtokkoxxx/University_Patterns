namespace Patterns.Facade_Proxy_Bridge.Decorator;

public class ColorEffectDecorator : Decorator
{
    public ColorEffectDecorator(Decorator? component) : base(component)
    {
    }

    public override void ApplyEffect()
    {
        Console.WriteLine("Apply color effect");
        base.ApplyEffect();
    }
}