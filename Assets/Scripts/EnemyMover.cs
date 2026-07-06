using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _followSpeed;
    [SerializeField] private float _maxFollowSpeed;
    [SerializeField] private Transform _followTarget;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_followTarget != null)
        {
            _rb.velocity = (_followTarget.position - transform.position).normalized * _followSpeed;
            transform.up = (_followTarget.position - transform.position);
        }
    }

}
