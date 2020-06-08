using System;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayView : View
{
    [SerializeField]
    private Text _scoreLabel;
    
    public void Setup(Action showGameOverView)
    {
        GameManager.Instance.SubscribeScore(SetCurrentScore);
        GameManager.Instance.SubscribeGameOver(showGameOverView);
        
        GameManager.Instance.Setup();
    }

    private void SetCurrentScore(int score)
    {
        _scoreLabel.text = $"Score: {score}";
    }
}