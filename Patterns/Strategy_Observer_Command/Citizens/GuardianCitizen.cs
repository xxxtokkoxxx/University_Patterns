using Patterns.Strategy_Observer_Command.Strategy;

namespace Patterns.Strategy_Observer_Command.Citizens;

public class GuardianCitizen : Citizen
{
    public GuardianCitizen(IMovementBehaviour movementBehaviour, IDialogBehaviour dialogBehaviour, ITradeBehaviour tradeBehaviour)
    {
        MovementBehaviour = movementBehaviour;
        DialogBehaviour = dialogBehaviour;
        TradeBehaviour = tradeBehaviour;
    }
}