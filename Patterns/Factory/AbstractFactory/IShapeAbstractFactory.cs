using Patterns.Factory.Shapes;

namespace Patterns.Factory.AbstractFactory;

public interface IShapeAbstractFactory
{
    IShape CreateTriangle();
    IShape CreateSphere();
    IShape CreateSquad();
}