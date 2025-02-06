using Patterns.BuilderAndPrototype.Builder;

namespace Patterns.BuilderAndPrototype.Player;

public interface IUnit
{
    void AddAbility(IAbility ability);
}