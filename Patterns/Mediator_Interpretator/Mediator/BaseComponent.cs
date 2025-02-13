namespace Patterns.Mediator_Interpretator.Mediator;

public class BaseComponent
{
    protected IMediator mediator;

    public void SetMediator(IMediator mediator)
    {
        this.mediator = mediator;
    }
}