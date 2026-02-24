using UnityEngine;

public class CameraComponent : MonoBehaviour
{
   [SerializeField] private GameObject _player;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = _player.transform.position + offset;
    }

}
