namespace Patterns.Facade_Proxy_Bridge.Decorator;

public class Decorator
{
    protected Decorator? Component;

    public Decorator(Decorator? component = null)
    {
        Component = component;
    }

    public virtual void ApplyEffect()
    {
        Component?.ApplyEffect();
    }
}

public class InitialDecorator : Decorator
{

}