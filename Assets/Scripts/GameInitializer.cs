﻿public class GameInitializer
{
    private SceneWireframe _wireframe;
    private IViewControllerFactory _factory;
    
    public GameInitializer(SceneWireframe wireframe, IViewControllerFactory factory)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public GameInitializer(SceneWireframe wireframe, AssetLoader assetLoader)
    {
        _wireframe = wireframe;
        _factory = new ViewControllerFactory(_wireframe, assetLoader);
    }
    
    public void Init()
    {
        var viewController = _factory.CreateMainMenuViewController();
        viewController.Setup();
        
        _wireframe.PresentViewController(viewController);
    }
}