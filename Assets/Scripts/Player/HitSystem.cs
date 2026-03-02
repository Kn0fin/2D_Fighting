using UnityEngine;

namespace Player
{
    public class HitSystem : MonoBehaviour
    {
        [SerializeField] internal Transform _hitPosition;
        [SerializeField] internal LayerMask _enemyLayer;
        [SerializeField] private float _hitDistance;

        private FlipSystem _flipSystem;

        private bool _hasHit;
        void Start()
        {
            _flipSystem = GetComponent<FlipSystem>();        
        }
        void Update()
        {
            OnHit();
        }         
        internal void OnHit()
        {
            _hasHit = false;
            Vector2 direction = _flipSystem.GetDirection();
            RaycastHit2D hit = Physics2D.Raycast(_hitPosition.position, direction, _hitDistance, _enemyLayer);
        
            if (Input.GetButtonDown("Fire3") && hit)
            {
                if (!_hasHit)
                {
                    Debug.Log("Fire");
                    _hasHit = true;
                }               
            }
        }
        private void OnDrawGizmos()
        {
            Vector2 direction = _flipSystem.GetDirection();
            Gizmos.color = Color.red;
            Gizmos.DrawLine(_hitPosition.position, _hitPosition.position + (Vector3)(direction * _hitDistance));
        }
    }
}
