namespace Patterns.Mediator_Interpretator.Mediator;

public class SettingsButton : BaseComponent
{
    public void OpenSettings()
    {
        Console.WriteLine("Settings button pressed");
        mediator.Notify(this, MainMenuMediator.SettingsButton);
    }
}