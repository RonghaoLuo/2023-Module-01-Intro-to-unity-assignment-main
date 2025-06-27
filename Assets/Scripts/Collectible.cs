using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int _worth = 1;

    [SerializeField] private GameManager _gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log(gameObject.name + " was hit by " + collision.gameObject.name);
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        _gameManager.CollectCoin(_worth);
    //        Destroy(gameObject);
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " was hit by " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            _gameManager.CollectCoin(_worth);
            Destroy(gameObject);
        }
    }
}
