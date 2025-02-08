using Patterns.Builder_Prototype.Player;

namespace Patterns.Builder_Prototype.Builder;

public interface IBuilder
{
    IUnit CreateUnit();
    IUnit GetUnit();
    void AddMeleeAttack(IUnit unit);
    void AddRangedAttack(IUnit unit);
    void AddMagicAttack(IUnit unit);
}