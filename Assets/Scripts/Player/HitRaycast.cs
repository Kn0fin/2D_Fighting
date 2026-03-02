using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace Player
{
    public class HitRaycast : MonoBehaviour
    {
        [SerializeField] internal Transform _hitPosition;
        [SerializeField] internal LayerMask _enemyLayer;
        [SerializeField] private float _hitDistance;

        private FlipSystem _flipSystem;
        private void Awake()
        {
            _hitPosition = GetComponent<Transform>();
            _flipSystem = GetComponent<FlipSystem>();
            
         
        }   
        internal void OnHitRaycast()
        {
            Vector2 direction = _flipSystem.GetDirection();
            
            RaycastHit2D hit = Physics2D.Raycast(_hitPosition.position, direction, _hitDistance, _enemyLayer);
                
            
          
                

        }

        private void OnDrawGizmos()
        {
            Vector2 direction = _flipSystem.GetDirection();
         Gizmos.color = Color.red;
            Gizmos.DrawLine(_hitPosition.position, _hitPosition.position + (Vector3)(direction * _hitDistance));
        }

        

    }

}
