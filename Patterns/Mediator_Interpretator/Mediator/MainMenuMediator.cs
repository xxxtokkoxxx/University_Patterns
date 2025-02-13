namespace Patterns.Mediator_Interpretator.Mediator;

public class MainMenuMediator : IMediator
{
    public const string StartGamePressed = "StartGamePressed";
    public const string QuitGamePressed = "QuitGamePressed";
    public const string SettingsButton = "EnterUserNamePressed";

    private SettingsButton _settingsButton;
    private MainMenuButton _mainMenuButton;

    public MainMenuMediator(SettingsButton settingsButton, MainMenuButton mainMenuButton)
    {
        _settingsButton = settingsButton;
        _settingsButton.SetMediator(this);
        _mainMenuButton = mainMenuButton;
        _mainMenuButton.SetMediator(this);
    }

    public void Notify(object sender, string payload)
    {
        Console.WriteLine("Mediator receives notification: " + payload);
        switch (payload)
        {
            case StartGamePressed:
                _mainMenuButton.StartGame();
                break;
            case QuitGamePressed:
                _mainMenuButton.QuitGame();
                break;
            case SettingsButton:
                _settingsButton.OpenSettings();
                break;
        }
    }
}