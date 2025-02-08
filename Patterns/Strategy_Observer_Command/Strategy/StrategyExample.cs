using Patterns.Strategy_Observer_Command.Citizens;
using Patterns.Strategy_Observer_Command.Command;

namespace Patterns.Strategy_Observer_Command.Strategy;

public class StrategyExample
{
    private Stack<ICommand> _commands;

    public void CrateCitizens()
    {
        ICitizen guard = new GuardianCitizen(new PatrolongtBehaviour(), new OpenToDialogBehaviour(), new ClosedToTradeBehavior());
        ICitizen peasant = new GuardianCitizen(new StayOnOneSpotBehaviour(), new OpenToDialogBehaviour(), new ClosedToTradeBehavior());
        ICitizen trader = new GuardianCitizen(new StayOnOneSpotBehaviour(), new OpenToDialogBehaviour(), new OpenToTradeBehaviour());

        guard.Move();
        peasant.Move();
        trader.Move();

        guard.Trade();
        peasant.Trade();
        trader.Trade();

        guard.Dialog();
        peasant.Dialog();
        trader.Dialog();

        peasant.ChangeTradBehaviour(new OpenToTradeBehaviour());
        peasant.Trade();

        guard.ChangeMovementBehaviour(new StayOnOneSpotBehaviour());
        guard.Move();

        trader.ChangeTradBehaviour(new ClosedToTradeBehavior());
        trader.Trade();
    }
}