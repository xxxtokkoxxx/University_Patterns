using Patterns.Builder_Prototype.Player;

namespace Patterns.Builder_Prototype.Builder;

public interface IDirector
{
    IUnit CreateMage();
    IUnit CreateMercenary();
    IUnit CreateWarrior();
    IUnit CreateBattleMage();
}