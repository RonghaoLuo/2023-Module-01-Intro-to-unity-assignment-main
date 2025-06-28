using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] PlayerControl _player;

    private GameManager _gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _player = FindAnyObjectByType<PlayerControl>();
        _gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " was hit by " + collision.gameObject.name);
        //StartCoroutine(_player.ShowPlayerTopText("BANG"));
        if (collision.gameObject.CompareTag("Player"))
        {
            _gameManager.GameOver();
        }
    }
}
