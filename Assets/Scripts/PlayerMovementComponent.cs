using UnityEngine;

public class PlayerMovementComponent : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 10f;

    private Rigidbody2D _rg;
    private Vector2 _movement;

    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        //OnHorizontalMovement();
        //OnVerticalMovement();
        _rg.linearVelocity = _movement * _moveSpeed;
    }

    private void OnHorizontalMovement()
    {
        _rg.linearVelocity = new Vector2(_movement.x * _moveSpeed, _rg.linearVelocity.y);
    }
    private void OnVerticalMovement()
    {
        _rg.linearVelocity = new Vector2(_movement.y * _moveSpeed, _rg.linearVelocity.x);
    }


}
