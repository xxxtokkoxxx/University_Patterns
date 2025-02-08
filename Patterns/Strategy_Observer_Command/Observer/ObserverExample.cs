using Patterns.Strategy_Observer_Command.Citizens;
using Patterns.Strategy_Observer_Command.Strategy;

namespace Patterns.Strategy_Observer_Command.Observer;

public class ObserverExample
{
    public void ObserverExamples()
    {
        IListener citizen = new GuardianCitizen(new PatrolongtBehaviour(), new OpenToDialogBehaviour(),
            new ClosedToTradeBehavior());
        IGamePauseObserver gamePauseObserver = new Observer();
        gamePauseObserver.Subscribe(citizen);
        gamePauseObserver.SendMessage(this, new GamePauseMessage(true));
        gamePauseObserver.SendMessage(this, new GamePauseMessage(false));
    }
}