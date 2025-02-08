using Patterns.Builder_Prototype.Builder;

namespace Patterns.Builder_Prototype.Player;

public interface IUnit
{
    void AddAbility(IAbility ability);
    object PartialCopy();
    object DeepCopy();
    string Name { get; set; }
    List<IAbility> Abilities { get; }
}