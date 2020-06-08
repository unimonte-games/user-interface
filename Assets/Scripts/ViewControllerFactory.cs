public class ViewControllerFactory : IViewControllerFactory
{
    private SceneWireframe _wireframe;
    private AssetLoader _assetLoader;

    public ViewControllerFactory(SceneWireframe wireframe, AssetLoader assetLoader)
    {
        _wireframe = wireframe;
        _assetLoader = assetLoader;
    }
    
    public MainMenuViewController CreateMainMenuViewController()
    {
        var mainMenuView = _assetLoader.LoadView<MainMenuView>("Main Menu View");
        return new MainMenuViewController(mainMenuView, _wireframe, this);
    }

    public SettingsMenuViewController CreateSettingsMenuViewController()
    {
        var settingsMenuView = _assetLoader.LoadView<SettingsMenuView>("Settings Menu View");
        return new SettingsMenuViewController(settingsMenuView);
    }

    public GamePlayViewController CreateGamePlayViewController()
    {
        var gamePlayView = _assetLoader.LoadView<GamePlayView>("Game Play View");
        return new GamePlayViewController(gamePlayView, _wireframe, this);
    }
}