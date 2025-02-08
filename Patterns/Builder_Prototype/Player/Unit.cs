using Patterns.Builder_Prototype.Builder;

namespace Patterns.Builder_Prototype.Player;

public class Unit : IUnit
{
    private List<IAbility> _abilities = new();
    public List<IAbility> Abilities => _abilities = new List<IAbility>();
    public string Name { get; set; }

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