public class GamePlayViewController : ViewController<GamePlayView>
{
    private SceneWireframe _wireframe;
    private IViewControllerFactory _factory;

    public GamePlayViewController(GamePlayView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Setup()
    {
        View.Setup(ShowMainMenuView);
    }

    private void ShowMainMenuView()
    {
        var viewController = _factory.CreateMainMenuViewController();
        viewController.Setup();
        
        _wireframe.PresentViewController(viewController);
    }
}