using System.IO;
using UnityEngine;

public class AssetLoader : MonoBehaviour
{
    private AssetBundle _viewBundle;

    private void Awake()
    {
        var path = Path.Combine(Application.streamingAssetsPath, "view_bundle");
        _viewBundle = AssetBundle.LoadFromFile(path);
    }

    public T LoadView<T>(string viewName) where T : View
    {
        var prefab = _viewBundle.LoadAsset<GameObject>(viewName);
        return Instantiate(prefab).GetComponent<T>();
    }
}