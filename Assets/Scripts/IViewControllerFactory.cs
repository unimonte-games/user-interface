public interface IViewControllerFactory
{
    MainMenuViewController CreateMainMenuViewController();
    SettingsMenuViewController CreateSettingsMenuViewController();
    GamePlayViewController CreateGamePlayViewController();
}