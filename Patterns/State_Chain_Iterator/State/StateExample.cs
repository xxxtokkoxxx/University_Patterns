namespace Patterns.State_Chain_Iterator.State;

public class StateExample
{
    public void StateExampleTest()
    {
        StateMachine stateMachine = new StateMachine();
        stateMachine.ChangeState(new BootstrapState(stateMachine));
    }
}