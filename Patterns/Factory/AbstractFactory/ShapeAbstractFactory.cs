using Patterns.Factory.Shapes;

namespace Patterns.Factory.AbstractFactory;

public class ShapeAbstractFactory : IShapeAbstractFactory
{
    public IShape CreateTriangle()
    {
        return new Triangle();
    }

    public IShape CreateSphere()
    {
        return new Sphere();
    }

    public IShape CreateSquad()
    {
        return new Squad();
    }
}