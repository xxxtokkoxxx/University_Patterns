namespace Patterns.Mediator_Interpretator.Mediator;

public interface IMediator
{
    void Notify(object authenticationInputField, string payload);
}