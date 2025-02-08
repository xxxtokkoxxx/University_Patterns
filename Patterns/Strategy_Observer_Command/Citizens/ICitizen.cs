using Patterns.Strategy_Observer_Command.Strategy;

namespace Patterns.Strategy_Observer_Command.Citizens;

public interface ICitizen
{
    void ChangeTradBehaviour(ITradeBehaviour tradeBehaviour);
    void ChangeDialogBehaviour(IDialogBehaviour dialogBehaviour);
    void ChangeMovementBehaviour(IMovementBehaviour movementBehaviour);
    void Trade();
    void Move();
    void Dialog();
}