using UnityEngine;

public class CameraFolower : MonoBehaviour
{
    [SerializeField] private GameObject _followTarget;
    // Update is called once per frame
    void Update()
    {
        if (_followTarget != null)
        {
            transform.position = Vector3.Lerp(transform.position, _followTarget.transform.position, Time.deltaTime * 2);
        }
    }
}
