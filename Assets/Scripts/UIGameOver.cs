using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    private GameManager _gameManager;

    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _timeText;
    [SerializeField] private TextMeshProUGUI _scoresPerSecText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
        _scoreText.text = "Your Score: " + _gameManager.GetScore().ToString();
        _timeText.text = "Your Time: " + _gameManager.GetTimeElapsed().ToString() + " sec";
        _scoresPerSecText.text = "Scores Per Second: " + _gameManager.GetScoresPerSec().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
