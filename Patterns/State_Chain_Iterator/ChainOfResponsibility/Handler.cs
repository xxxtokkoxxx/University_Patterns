namespace Patterns.State_Chain_Iterator.ChainOfResponsibility;

public abstract class Handler
{
    protected Handler Next;
    protected abstract string Operation { get; }
    public void SetNext(Handler next) => Next = next;

    public abstract void Handle(string operation);
}