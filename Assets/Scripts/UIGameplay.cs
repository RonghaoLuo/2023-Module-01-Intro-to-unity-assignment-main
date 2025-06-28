using TMPro;
using UnityEngine;

public class UIGameplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _timeElapsed;

    private GameManager _gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        _timeElapsed.text = "In Seconds: " + ((int)_gameManager.GetTimeElapsed()).ToString();
    }

    public void UpdateScoreText(int score)
    {
        _scoreText.text = "Score: " + score.ToString();
    }
}
