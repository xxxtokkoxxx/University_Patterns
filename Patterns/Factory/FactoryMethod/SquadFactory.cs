using Patterns.Factory.AbstractFactory;
using Patterns.Factory.Shapes;

namespace Patterns.Factory.FactoryMethod;

public class SquadFactory : ICreator
{
    public IShape FactoryMethod()
    {
        return new Squad();
    }
}