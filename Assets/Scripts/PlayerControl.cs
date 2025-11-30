using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _myRigidbody;
    [SerializeField] private Animator _myAnimator;
    [SerializeField] private SpriteRenderer _mySpriteRenderer;
    [SerializeField] private Transform _playerTop;
    [SerializeField] private HeldButton _leftButton, _rightButton, _jumpButton;

    [SerializeField] private float _jumpForce = 1f;
    [SerializeField] private float _horizontalSpeed = 1f;

    private float _horizontalInput;

    // Player States
    public bool canJump = true;    // Player is gounded
    public bool isRunning = false;
    public bool facingRight = true;

    // Prefabs
    [SerializeField] private TextMeshProUGUI _playerTopTextPrefab;

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
        if ((Input.GetKey(KeyCode.Space) || _jumpButton.isHeld) && canJump)
        {
            Jump();
        }
        //      Running
        float keyboardHorizontalInput = Input.GetAxisRaw("Horizontal");
        float touchHorizontalInput = 0;
        if (_leftButton.isHeld) { touchHorizontalInput -= 1; }
        if (_rightButton.isHeld) { touchHorizontalInput += 1; }

        _horizontalInput = keyboardHorizontalInput != 0? keyboardHorizontalInput: 
            touchHorizontalInput;
        transform.position += transform.right * _horizontalInput * Time.deltaTime * _horizontalSpeed;
        if (_horizontalInput != 0)
        {
            isRunning = true;
        }
        else { isRunning = false; }

        // Animations
        //      Jump
        _myAnimator.SetBool("isGrounded", canJump);
        //      Running
        _myAnimator.SetBool("isRunning", isRunning);
        //      Sprite Direction
        if (_horizontalInput > 0)
        {
            facingRight = true;
            _mySpriteRenderer.flipX = false;
        }
        else if (_horizontalInput < 0)
        {
            facingRight= false;
            _mySpriteRenderer.flipX = true;
        }

        // Collision Events
        //      with enemies
        //      with obstacles
    }

    private void Jump()
    {
        _myRigidbody.linearVelocityY = 0f;
        _myRigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        canJump = false;
    }

    ///// <summary>
    ///// Shows a text above the Player
    ///// </summary>
    ///// <param name="text"></param>
    //public IEnumerator ShowPlayerTopText(string text)
    //{
    //    // Clone
    //    TextMeshProUGUI playerTopTextdClone = Instantiate(_playerTopTextPrefab, transform);
    //    // Position
    //    playerTopTextdClone.transform.position = _playerTop.position;
    //    // Set the text
    //    playerTopTextdClone.text = text;
    //    yield return new WaitForSeconds(1);
    //    //Destroy(playerTopTextdClone );
    //}
}
