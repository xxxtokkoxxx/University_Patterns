using Patterns.BuilderAndPrototype.Builder;

namespace Patterns.BuilderAndPrototype.Player;

public class Unit : IUnit
{
    private List<IAbility> _abilities = new();

    public string Name { get; }

    public void AddAbility(IAbility ability)
    {
        _abilities.Add(ability);
    }

    public object PartialCopy()
    {
        Unit clone = (Unit)MemberwiseClone();
        return clone;
    }

    public object DeepCopy()
    {
        Unit clone = (Unit)MemberwiseClone();
        return clone;
    }
}