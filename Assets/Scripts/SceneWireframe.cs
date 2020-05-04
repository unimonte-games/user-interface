using UnityEngine;

public class SceneWireframe : MonoBehaviour
{
    [SerializeField] private Transform _holder;

    public void PresentViewController<T>(ViewController<T> viewController) where T : View
    {
        PresentView(viewController.View);
    }
    
    public void PresentView(View view)
    {
        foreach (Transform child in _holder) {
            Destroy(child.gameObject);
        }
        
        view.transform.SetParent(_holder, false);
    }
}