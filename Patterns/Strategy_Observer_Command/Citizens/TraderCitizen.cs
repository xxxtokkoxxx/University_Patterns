using Patterns.Strategy_Observer_Command.Strategy;

namespace Patterns.Strategy_Observer_Command.Citizens;

public class TraderCitizen : Citizen
{
    public TraderCitizen(IMovementBehaviour movementBehaviour, IDialogBehaviour dialogBehaviour, ITradeBehaviour tradeBehaviour)
    {
        MovementBehaviour = movementBehaviour;
        DialogBehaviour = dialogBehaviour;
        TradeBehaviour = tradeBehaviour;
    }
}