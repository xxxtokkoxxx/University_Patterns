namespace Patterns.Strategy_Observer_Command.Observer;

public class GamePauseMessage : IMessage
{
    public bool IsPaused { get; private set; }

    public GamePauseMessage(bool isPaused)
    {
        IsPaused = isPaused;
    }
}