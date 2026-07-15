using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private Camera _camera;
    [SerializeField] private float _speed = 5f;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out EnemyHealth enemyHealth))
        {
            enemyHealth.GetDamage(_damage);
            Destroy(gameObject);
        }
      
    }
    public void Move(Vector2 point)
    {
        Vector2 direction = (point - (Vector2)transform.position).normalized * _speed;
        _rb.velocity = direction;
    }
}
