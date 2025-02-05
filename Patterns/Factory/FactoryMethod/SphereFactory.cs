using Patterns.Factory.AbstractFactory;
using Patterns.Factory.Shapes;

namespace Patterns.Factory.FactoryMethod;

public class SphereFactory : ICreator
{
    public IShape FactoryMethod()
    {
        return new Sphere();
    }
}