using UnityEngine;

namespace Player
{
    public class PlayerSwitchAnimations : MonoBehaviour
    {       
        private Animator _animator;
        private PlayerMovementComponent _playerMovement;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _playerMovement = GetComponent<PlayerMovementComponent>();
        }
        void Start()
        {
            
        }
        void Update()
        {
         
        }

        internal void OnWalk()
        {
            _animator.SetFloat("Walk", Mathf.Abs(_playerMovement._movement.magnitude));
        }
    }

}
