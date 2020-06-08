using UnityEngine;

public class InspectorViewControllerFactory : MonoBehaviour, IViewControllerFactory
{
    [SerializeField]
    private SceneWireframe _wireframe;

    [Header("Prefabs")]
    
    [SerializeField]
    private MainMenuView _mainMenuViewPrefab;

    [SerializeField]
    private SettingsMenuView _settingsMenuViewPrefab;

    [SerializeField]
    private GamePlayView _gamePlayViewPrefab;

    public MainMenuViewController CreateMainMenuViewController()
    {
        var mainMenuView = Instantiate(_mainMenuViewPrefab);
        return new MainMenuViewController(mainMenuView, _wireframe, this);
    }

    public SettingsMenuViewController CreateSettingsMenuViewController()
    {
        var settingsMenuView = Instantiate(_settingsMenuViewPrefab);
        return new SettingsMenuViewController(settingsMenuView);
    }

    public GamePlayViewController CreateGamePlayViewController()
    {
        var gamePlayView = Instantiate(_gamePlayViewPrefab);
        return new GamePlayViewController(gamePlayView, _wireframe, this);
    }
}