using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Transform _playerTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerTransform = FindAnyObjectByType<PlayerControl>().GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_playerTransform.position.x, transform.position.y, transform.position.z);
    }
}
