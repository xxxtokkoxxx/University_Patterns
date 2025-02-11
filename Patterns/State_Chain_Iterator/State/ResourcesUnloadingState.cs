namespace Patterns.State_Chain_Iterator.State;

public class ResourcesUnloadingState : IState
{
    public void Enter()
    {
        Console.WriteLine("Enter resources unloading state");
    }

    public void Exit()
    {
        Console.WriteLine("Exit resources unloading state");
    }
}