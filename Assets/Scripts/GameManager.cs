using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _score = 0;
    [SerializeField] private int _numOfObstacles = 1;
    [SerializeField] private int _numOfCollectibles = 1;

    [SerializeField] private PlayerControl _player;
    [SerializeField] private GameObject _grounds;
    [SerializeField] private UIGameplay _gameplayUI;
    [SerializeField] private UIGameOver _gameOverUI;

    private float _timeElapsed = 0;
    private bool isGameOver;

    // for the ground
    public float generatesPosXMin = -9f;
    public float generatesPosXMax = 9f;
    public float obstaclesNewPosY = -4.42f;
    public float collectiblesNewPosY = 0f;

    // Prefabs
    [SerializeField] private GameObject _groundPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameplayUI.UpdateScoreText(_score);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            _timeElapsed += Time.deltaTime;
        }
    }

    /// <summary>
    /// Increases the number of collected coins by <paramref name="coins"/>
    /// </summary>
    /// <param name="coins"></param>

    public void GenerateGroundOnLeftOf(GameObject ground)
    {
        Vector2 NewGroundPos = new Vector2( ground.transform.position.x - 20,
                                            ground.transform.position.y     );

        // generate new ground inside the grounds gameobject
        GameObject newGround = Instantiate(_groundPrefab, _grounds.transform);
        // set it to correct coord
        newGround.transform.position = NewGroundPos;
        // save the reference to the ground script
        Ground newGroundCompGround = newGround.GetComponent<Ground>();
        // connect to the game manager
        newGroundCompGround.ConnectToGameManager();
        // disable the right gen trigger of the new ground; 
        newGroundCompGround.DisableRightGenTrigger();
        // generate obstacles and collectibles
        newGroundCompGround.GenerateObstacles(_numOfObstacles);
        newGroundCompGround.GenerateCollectibles(_numOfCollectibles);
    }

    public void GenerateGroundOnRightOf(GameObject ground)
    {
        Vector2 NewGroundPos = new Vector2( ground.transform.position.x + 20,
                                            ground.transform.position.y         );

        // generate new ground inside the grounds gameobject
        GameObject newGround = Instantiate(_groundPrefab, _grounds.transform);
        // set it to correct coord
        newGround.transform.position = NewGroundPos;
        // save the reference to the ground script
        Ground newGroundCompGround = newGround.GetComponent<Ground>();
        // connect to the game manager
        newGroundCompGround.ConnectToGameManager();
        // disable the right gen trigger of the new ground
        newGroundCompGround.DisableLeftGenTrigger();
        // generate obstacles and collectibles
        newGroundCompGround.GenerateObstacles(_numOfObstacles);
        newGroundCompGround.GenerateCollectibles(_numOfCollectibles);
    }

    public void AddScore(int worth)
    {
        _score += worth;
        _gameplayUI.UpdateScoreText(_score);
    }

    public void GameOver()
    {
        isGameOver = true;

        _player.gameObject.SetActive(false);
        _gameplayUI.gameObject.SetActive(false);

        _gameOverUI.gameObject.SetActive(true);
    }

    public int GetScore()
    {
        return _score;
    }

    public float GetScoresPerSec()
    {
        return _score / _timeElapsed;
    }

    public float GetTimeElapsed()
    {
        return _timeElapsed;
    }
}
