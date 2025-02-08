namespace Patterns.Strategy_Observer_Command.Observer;

public interface IGamePauseObserver
{
    void SendMessage(object sender, IMessage message);
    void Subscribe(IListener listener);
    void Unsubscribe(IListener listener);
}