namespace Patterns.State_Chain_Iterator.State;

public class StateMachine
{
    private IState _currentState;

    public IState CurrentState => _currentState;

    public void ChangeState(IState newState)
    {
        if (_currentState != null)
        {
            _currentState.Exit();
            Console.WriteLine("Exit state: " + _currentState.GetType().Name);
        }

        _currentState = newState;
        _currentState.Enter();
        Console.WriteLine("Enter state: " + _currentState.GetType().Name);
    }
}