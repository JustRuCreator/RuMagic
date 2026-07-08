using UnityEngine;

public class CameraFolower : MonoBehaviour
{
    [SerializeField] private GameObject _followTarget;
    void Update()
    {
        if (_followTarget != null)
        {
            transform.position = Vector3.Lerp(transform.position, _followTarget.transform.position, Time.deltaTime * 2);
        }
    }
}
