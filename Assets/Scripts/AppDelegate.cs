using System.Collections;
using UnityEngine;

public class AppDelegate : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;
    [SerializeField] private AssetLoader _assetLoader;
    
    [Header("Test Only")]
    
    [SerializeField] private InspectorViewControllerFactory _inspectorFactory;
    
    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        Init();
    }

    private void Init()
    {
        new GameInitializer(_wireframe, _assetLoader).Init();
    }
}
