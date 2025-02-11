namespace Patterns.State_Chain_Iterator.State;

public class AppLoopState : IState
{
    private readonly StateMachine _stateMachine;

    public AppLoopState(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Console.WriteLine("Enter app loop state");
        _stateMachine.ChangeState(new ResourcesUnloadingState());
    }

    public void Exit()
    {
        Console.WriteLine("Exit app loop state");
    }
}