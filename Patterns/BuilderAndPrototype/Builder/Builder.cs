using Patterns.BuilderAndPrototype.Player;

namespace Patterns.BuilderAndPrototype.Builder;

public class Builder : IBuilder
{
    private IUnit _unit;

    public IUnit CreateUnit()
    {
        _unit = new Unit();
        return _unit;
    }

    public IUnit GetUnit()
    {
        return _unit;
    }

    public void AddMeleeAttack(IUnit unit)
    {
        unit.AddAbility(new MeleeAttack());
    }

    public void AddRangedAttack(IUnit unit)
    {
        unit.AddAbility(new RangedAttack());
    }

    public void AddMagicAttack(IUnit unit)
    {
        unit.AddAbility(new MagicAttack());
    }
}