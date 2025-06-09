using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _collectedCoins = 0;

    [SerializeField] private PlayerControl _playerControl;

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

    
}
