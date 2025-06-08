using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 1f;
    [SerializeField] private Rigidbody2D _myRigidbody;
    [SerializeField] private Animator _myAnimator;
    [SerializeField] private float _horizontalSpeed = 1f;

    private float _horizontalInput;

    public bool canJump;    // Player is gounded
    public bool isRunning;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movements
        //      Jump
        //transform.position += transform.up * Input.GetAxis("Jump") * Time.deltaTime * _jumpSpeed;
        if (Input.GetKey(KeyCode.Space) && canJump
            )
        {
            _myRigidbody.linearVelocityY = 0f;
            _myRigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }
        //      Running
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.position += transform.right * _horizontalInput * Time.deltaTime * _horizontalSpeed;
        if (Input.GetButton("Horizontal")) { isRunning = true; }
        else { isRunning = false; }

            // Animations
            //      Jump
            _myAnimator.SetBool("isGrounded", canJump);
        //      Running
        _myAnimator.SetBool("isRunning", isRunning);
    }
}
