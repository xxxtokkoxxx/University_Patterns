namespace Patterns.Strategy_Observer_Command.Observer;

public interface IListener
{
    void Receive(IMessage message);
}