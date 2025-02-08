using Patterns.Builder_Prototype.Builder;
using Patterns.Builder_Prototype.Player;

namespace Patterns.Builder_Prototype.Prototype;

public class PrototypeExample
{
    private IUnit _unit;

    public void PartialCopy()
    {
        _unit = new Unit();
        _unit.Name = "test";
        _unit.AddAbility(new MagicAttack());
        Console.WriteLine($"Unit name: {_unit.Name}, unit abilities count: {_unit.Abilities.Count}");
        IUnit copy = (IUnit)_unit.PartialCopy();
        Console.WriteLine($"Copy name: {copy.Name}, copy abilities count: {copy.Abilities.Count}");
    }

    public void DeepCopy()
    {
        _unit = new Unit();
        _unit.Name = "test";
        Console.WriteLine($"Unit name: {_unit.Name}, unit abilities count: {_unit.Abilities.Count}");
        IUnit copy = (IUnit)_unit.DeepCopy();
        Console.WriteLine($"Copy name: {copy.Name}, copy abilities count: {copy.Abilities.Count}");
    }
}