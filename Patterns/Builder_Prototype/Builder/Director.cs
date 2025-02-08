using Patterns.Builder_Prototype.Player;

namespace Patterns.Builder_Prototype.Builder;

public class Director : IDirector
{
    public Builder _builder = new Builder();
    public IUnit CreateMage()
    {
        IUnit unit = _builder.CreateUnit();
        unit.AddAbility(new MagicAttack());
        return unit;
    }

    public IUnit CreateMercenary()
    {
        IUnit unit = _builder.CreateUnit();
        unit.AddAbility(new MeleeAttack());
        unit.AddAbility(new RangedAttack());
        return unit;
    }

    public IUnit CreateWarrior()
    {
        IUnit unit = _builder.CreateUnit();
        unit.AddAbility(new MeleeAttack());
        unit.AddAbility(new RangedAttack());
        return unit;
    }

    public IUnit CreateBattleMage()
    {
        IUnit unit = _builder.CreateUnit();
        unit.AddAbility(new MeleeAttack());
        unit.AddAbility(new MagicAttack());
        return unit;    }
}