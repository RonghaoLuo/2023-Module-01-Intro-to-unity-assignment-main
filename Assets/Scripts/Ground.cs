using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private GameObject _leftGenTrigger;
    [SerializeField] private GameObject _rightGenTrigger;
    [SerializeField] private GameManager _gameManager;

    // Prefabs
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private GameObject _collectiblePrefab;

    private void Start()
    {
        //_gameManager = FindAnyObjectByType<GameManager>(); //doesn't work
    }

    public void DisableLeftGenTrigger()
    {
        _leftGenTrigger.SetActive(false);
    }

    public void DisableRightGenTrigger()
    {
        _rightGenTrigger.SetActive(false);
    }

    public void GenerateObstacles(int numOfObstacles)
    {
        // generate randomly on the ground
        for (int i = 0; i < numOfObstacles; i++)
        {
            float generatesPosX = Random.Range(
                transform.position.x + _gameManager.generatesPosXMin,
                transform.position.x + _gameManager.generatesPosXMax);

            // making the new pos
            Vector2 newPos = new Vector2(generatesPosX, _gameManager.obstaclesNewPosY);
            // instantiating the new obstacle
            GameObject newObstacle = Instantiate(_obstaclePrefab, transform);
            // moving the obstacle to the pos
            newObstacle.transform.position = newPos;
        }
    }

    public void GenerateCollectibles(int numOfPickups)
    {
        // generate randomly and fall on the ground
        for (int i = 0; i < numOfPickups; i++)
        {
            float generatesPosX = Random.Range(
                transform.position.x + _gameManager.generatesPosXMin,
                transform.position.x + _gameManager.generatesPosXMax);

            // making the new pos
            Vector2 newPos = new Vector2(generatesPosX, _gameManager.collectiblesNewPosY);
            // instantiating the new pickup
            GameObject newCollectible = Instantiate(_collectiblePrefab, transform);
            // moving the obstacle to the pos
            newCollectible.transform.position = newPos;
        }
    }

    public void ConnectToGameManager()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
    }
}
