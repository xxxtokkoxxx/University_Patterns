namespace Patterns.Mediator_Interpretator.Mediator;

public class MediatorExample
{
    static void MediatorExampleMethod()
    {
        SettingsButton settingsButton = new SettingsButton();
        MainMenuButton mainMenuButton = new MainMenuButton();

        settingsButton.OpenSettings();
        mainMenuButton.StartGame();
        mainMenuButton.QuitGame();
    }
}