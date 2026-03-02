using UnityEngine;

namespace Player
{
    public class FlipSystem : MonoBehaviour
    {
        internal SpriteRenderer _sprite;
        internal PlayerMovementComponent _player;

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
                return;
            }
            else if(_player._movement.x < 0) 
            { 
                _sprite.flipX = true;
                return;
            }
        }
    }

}
