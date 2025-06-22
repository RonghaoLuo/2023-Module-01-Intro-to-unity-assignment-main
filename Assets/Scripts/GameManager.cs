using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _collectedCoins = 0;

    [SerializeField] private PlayerControl _playerControl;
    [SerializeField] private GameObject _grounds;

    // Prefabs
    [SerializeField] private GameObject _groundPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Increases the number of collected coins by <paramref name="coins"/>
    /// </summary>
    /// <param name="coins"></param>
    public void CollectCoin(int coins)
    {
        _collectedCoins += coins;
    }

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
        // disable the right gen trigger of the new ground; 
        newGroundCompGround.DisableRightGenTrigger();

        GeneratePickups(newGround);
        GenerateObstacles();
    }

    public void GenerateGroundOnRightOf(GameObject ground)
    {
        Vector2 NewGroundPos = new Vector2( ground.transform.position.x + 20,
                                            ground.transform.position.y         );

        // generate new ground inside the grounds gameobject
        GameObject newGround = Instantiate(_groundPrefab, _grounds.transform);
        // set it to correct coord
        newGround.transform.position = NewGroundPos;
        // disable the right gen trigger of the new ground
        newGround.GetComponent<Ground>().DisableLeftGenTrigger();
    }

    private void GeneratePickups(GameObject ground)
    {
        // generate randomly and fall on the ground
    }

    private void GenerateObstacles()
    {
        // generate randomly on the ground
    }
}
