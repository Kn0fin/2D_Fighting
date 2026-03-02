using UnityEngine;

namespace Player
{
    public class HitSystem : MonoBehaviour
    {
        [SerializeField] internal HitRaycast _hitRaycast;
        void Start()
        {
            _hitRaycast = GetComponent<HitRaycast>();
        }

        // Update is called once per frame
        void Update()
        {
            OnHit();
        }

        //private void OnCheckDistance()
        //{
        //    Vector2 direction = _hitRaycast._enemyLayer - _hitRaycast._hitPosition;
        //}

        internal void OnHit()
        {
            if (Input.GetButtonDown("Fire3"))
            {               
                Debug.Log("Fire");
            }
        }
    }

}
