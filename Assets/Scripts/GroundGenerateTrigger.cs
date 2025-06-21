using UnityEngine;

public class GroundGenerateTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _thisGround;
    
    private GameManager _gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == "GroundLeftGenerateTrigger")
            {
                _gameManager.GenerateGroundOnLeftOf(_thisGround);
            }
            else if (gameObject.name == "GroundRightGenerateTrigger")
            {
                _gameManager.GenerateGroundOnRightOf(_thisGround);
            }
            gameObject.SetActive(false);
        }
    }
}
