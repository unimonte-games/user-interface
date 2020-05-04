using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Text _titleText;
    
    public void Setup(string title)
    {
        Debug.Log("Teste");
        _titleText.text = title;
    }
}