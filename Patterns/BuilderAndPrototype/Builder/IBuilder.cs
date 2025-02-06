using Patterns.BuilderAndPrototype.Player;

namespace Patterns.BuilderAndPrototype.Builder;

public interface IBuilder
{
    IUnit CreateUnit();
    IUnit GetUnit();
    void AddMeleeAttack(IUnit unit);
    void AddRangedAttack(IUnit unit);
    void AddMagicAttack(IUnit unit);
}