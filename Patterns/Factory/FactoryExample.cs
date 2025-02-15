using Patterns.Factory.AbstractFactory;
using Patterns.Factory.FactoryMethod;
using Patterns.Factory.Shapes;

namespace Patterns.Factory;

public class FactoryExample
{
    public void RenderShapesWithFactoryMethod()
    {
        IShape shape;
        ICreator creator;

        creator = new TriangleFactory();
        shape = creator.FactoryMethod();
        Console.WriteLine(shape.Render());

        creator = new SphereFactory();
        shape = creator.FactoryMethod();
        Console.WriteLine(shape.Render());

        creator = new SquadFactory();
        shape = creator.FactoryMethod();
        Console.WriteLine(shape.Render());
    }

    public void RenderShapesWithAbstractFactory()
    {
        IShape shape;
        IShapeAbstractFactory shapeAbstractFactory = new ShapeAbstractFactory();

        shape = shapeAbstractFactory.CreateSphere();
        Console.WriteLine(shape.Render());

        shape = shapeAbstractFactory.CreateSquad();
        Console.WriteLine(shape.Render());

        shape = shapeAbstractFactory.CreateTriangle();
        Console.WriteLine(shape.Render());
    }
}