using Patterns.Factory.Shapes;

namespace Patterns.Factory.FactoryMethod;

public class TriangleFactory : ICreator
{
    public IShape FactoryMethod()
    {
        return new Triangle();
    }
}