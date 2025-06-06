using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] private PlayerControl _player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player.canJump = true;
        }
    }
}
