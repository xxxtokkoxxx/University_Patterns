using Patterns.BuilderAndPrototype.Player;

namespace Patterns.BuilderAndPrototype.Builder;

public interface IDirector
{
    IUnit CreateMage();
    IUnit CreateMercenary();
    IUnit CreateWarrior();
    IUnit CreateBattleMage();
}