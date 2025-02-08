using Patterns.Strategy_Observer_Command.Strategy;

namespace Patterns.Strategy_Observer_Command.Citizens;

public class PeasantCitizen : Citizen
{
    public PeasantCitizen(IMovementBehaviour movementBehaviour, IDialogBehaviour dialogBehaviour, ITradeBehaviour tradeBehaviour)
    {
        MovementBehaviour = movementBehaviour;
        DialogBehaviour = dialogBehaviour;
        TradeBehaviour = tradeBehaviour;
    }
}