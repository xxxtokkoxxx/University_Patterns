namespace Patterns.Facade_Proxy_Bridge.Decorator;

public class SizeEffectDecorator : Decorator
{
    public SizeEffectDecorator(Decorator? component) : base(component)
    {
    }

    public override void ApplyEffect()
    {
        Console.WriteLine("Apply size effect");
        base.ApplyEffect();
    }
}