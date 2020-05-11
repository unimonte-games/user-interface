using UnityEngine;

public class MainMenuViewController : ViewController<MainMenuView>
{
    private ViewControllerFactory _factory;

    public MainMenuViewController(MainMenuView view, ViewControllerFactory factory) : base(view)
    {
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
        Debug.Log("Play");
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