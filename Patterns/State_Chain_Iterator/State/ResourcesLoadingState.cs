namespace Patterns.State_Chain_Iterator.State;

public class ResourcesLoadingState : IState
{
    private StateMachine _stateMachine;

    public ResourcesLoadingState(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Console.WriteLine("Enter resources loading state");
        _stateMachine.ChangeState(new AppLoopState(_stateMachine));
    }

    public void Exit()
    {
        Console.WriteLine("Exit resources loading state");
    }
}