using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 1f;
    [SerializeField] private Rigidbody2D _myRigidbody;

    public bool canJump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.up * Input.GetAxis("Jump") * Time.deltaTime * _jumpSpeed;
        if (Input.GetKey(KeyCode.Space) && canJump
            )
        {
            _myRigidbody.linearVelocityY = 0f;
            _myRigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }
    }
}
