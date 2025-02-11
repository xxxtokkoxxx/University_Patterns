namespace Patterns.State_Chain_Iterator.State;

public class BootstrapState : IState
{
    private readonly StateMachine _stateMachine;

    public BootstrapState(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Console.WriteLine("Enter boostrap state");
        _stateMachine.ChangeState(new ResourcesLoadingState(_stateMachine));

    }

    public void Exit()
    {
        Console.WriteLine("Exit boostrap state");
    }
}