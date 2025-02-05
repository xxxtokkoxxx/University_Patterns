using Patterns.Factory.Shapes;

namespace Patterns.Factory.FactoryMethod;

public interface ICreator
{
    IShape FactoryMethod();
}