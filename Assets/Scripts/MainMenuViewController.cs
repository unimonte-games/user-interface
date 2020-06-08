using UnityEngine;

public class MainMenuViewController : ViewController<MainMenuView>
{
    private SceneWireframe _wireframe;
    private IViewControllerFactory _factory;

    public MainMenuViewController(MainMenuView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Setup()
    {
        View.Setup(Application.productName);
        
        View.AddButton(PlayGame, "Jogar");
        View.AddButton(ShowSettingsMenu, "Configurações");
/*
 * https://docs.unity3d.com/Manual/PlatformDependentCompilation.html
 */
#if UNITY_STANDALONE
        View.AddButton(QuitGame, "Sair");
#endif
    }

    private void PlayGame()
    {
        var viewController = _factory.CreateGamePlayViewController();
        viewController.Setup();
        
        _wireframe.PresentViewController(viewController);
    }

    private void ShowSettingsMenu()
    {
        var viewController = _factory.CreateSettingsMenuViewController();
        viewController.Setup(() =>
        {
            viewController.Dismiss();
        });

        viewController.View.transform.SetParent(View.transform, false);
    }

    private void QuitGame()
    {
        Debug.Log("Quit");
    }
}