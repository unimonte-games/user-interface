using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Action<int> _scoreViewUpdate;
    private Action _gameOverViewUpdate;

    private bool _isGameRunning;
    private int _currentScore;
    
    private void Start()
    {
        if (Instance == null) {
            Instance = gameObject.GetComponent<GameManager>();
        }
    }

    private void Update()
    {
        if (!_isGameRunning) return;

        if (Input.GetKeyDown(KeyCode.Space)) {
            _currentScore++;
            _scoreViewUpdate?.Invoke(_currentScore);
        }

        if (_currentScore > 10) {
            _isGameRunning = false;
            _gameOverViewUpdate?.Invoke();
        }
    }

    public void Setup()
    {
        _isGameRunning = true;
    }

    public void SubscribeScore(Action<int> scoreViewUpdate)
    {
        _scoreViewUpdate = scoreViewUpdate;
    }

    public void SubscribeGameOver(Action gameOverViewUpdate)
    {
        _gameOverViewUpdate = gameOverViewUpdate;
    }
}
