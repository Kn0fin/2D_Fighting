using UnityEngine;
using UnityEngine.UIElements;


namespace Player
{
    public class PlayerMovementComponent : MonoBehaviour
    {

        [SerializeField] private float _moveSpeed = 10f;
        [SerializeField] private float _jumpForce = 10f;

        internal FlipSystem _flipSystem;
        internal PlayerSwitchAnimations _playerSwitchAnimations;

        private Rigidbody2D _rg;
        internal Vector2 _movement;

        void Start()
        {
            _rg = GetComponent<Rigidbody2D>();
            _flipSystem = GetComponent<FlipSystem>();
            _playerSwitchAnimations = GetComponent<PlayerSwitchAnimations>();
        }


        void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");

            OnMovement();
            _flipSystem.OnFlip();
            _playerSwitchAnimations.OnWalk();
            OnJump();
        }
        private void OnMovement()
        {
            _rg.linearVelocity = _movement * _moveSpeed;
        }

        private void OnJump()
        {
            if (Input.GetButtonDown("Jump"))
            {
                _rg.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
                Debug.Log("Jump");
            }
        }
    }

}
