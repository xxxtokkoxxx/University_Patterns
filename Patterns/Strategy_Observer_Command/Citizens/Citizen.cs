using Patterns.Strategy_Observer_Command.Observer;
using Patterns.Strategy_Observer_Command.Strategy;

namespace Patterns.Strategy_Observer_Command.Citizens;

public class Citizen : ICitizen, IListener
{
    protected IMovementBehaviour MovementBehaviour;
    protected IDialogBehaviour DialogBehaviour;
    protected ITradeBehaviour TradeBehaviour;

    public virtual void ChangeTradBehaviour(ITradeBehaviour tradeBehaviour)
    {
        TradeBehaviour = tradeBehaviour;
    }

    public virtual void ChangeDialogBehaviour(IDialogBehaviour dialogBehaviour)
    {
        DialogBehaviour = dialogBehaviour;
    }

    public virtual void ChangeMovementBehaviour(IMovementBehaviour movementBehaviour)
    {
        MovementBehaviour = movementBehaviour;
    }

    public void Trade()
    {
        TradeBehaviour.DoTrade();
    }

    public void Move()
    {
        MovementBehaviour.DoMovement();
    }

    public void Dialog()
    {
        DialogBehaviour.DoDialog();
    }

    public void Receive(IMessage message)
    {
        switch (message)
        {
            case GamePauseMessage msg:
                FreezeUnit(msg.IsPaused);
                break;
        }
    }

    private void FreezeUnit(bool isFreeze)
    {
        Console.WriteLine($"Freezing unit {this}: {isFreeze}");
    }
}