namespace Patterns.Strategy_Observer_Command.Observer;

public class Observer : IGamePauseObserver
{
    private List<IListener> _listeners = new();

    public void SendMessage(object sender, IMessage message)
    {
        foreach (IListener listener in _listeners)
        {
            listener.Receive(message);
        }
    }

    public void Subscribe(IListener listener)
    {
        _listeners.Add(listener);
    }

    public void Unsubscribe(IListener listener)
    {
        _listeners.Remove(listener);
    }
}