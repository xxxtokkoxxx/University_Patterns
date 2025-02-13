namespace Patterns.Mediator_Interpretator.Mediator;

public class MainMenuButton : BaseComponent
{
    public void StartGame()
    {
        Console.WriteLine("Start game button pressed");
        mediator.Notify(this, MainMenuMediator.StartGamePressed);
    }

    public void QuitGame()
    {
        Console.WriteLine("Quit game button pressed");
        mediator.Notify(this, MainMenuMediator.QuitGamePressed);
    }
}