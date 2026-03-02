using UnityEngine;

namespace Player
{
    public class FlipSystem : MonoBehaviour
    {
        internal SpriteRenderer _sprite;
        internal PlayerMovementComponent _player;

        public bool IsPlayerSide {  get; private set; } = true;
        
        private void Awake()
        {
            _sprite = GetComponent<SpriteRenderer>();
            _player = GetComponent<PlayerMovementComponent>();
           
        }
        internal void OnFlip()
        {
            if (_player._movement.x > 0)
            {
                _sprite.flipX = false;
                IsPlayerSide = true;
               
                return;
            }
            else if(_player._movement.x < 0) 
            { 
                _sprite.flipX = true;
                IsPlayerSide = false;
                return;
            }
        }

        internal Vector2 GetDirection()
        {
            return IsPlayerSide ? Vector2.right : Vector2.left;
        }
    }

}
