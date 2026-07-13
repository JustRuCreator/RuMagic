using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private LayerMask _enemyLayerMask;

    private IEnumerator Spawn()
    {
        for (float i = 0; i <= 5; i += 0.01f)
        {
            transform.localScale = new Vector3 (i, i, 1);
            yield return new WaitForSeconds(0.001f);
        }

        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, 5, _enemyLayerMask);
        foreach (Collider2D enemyCollider in enemies)
        {
            if (enemyCollider.TryGetComponent(out EnemyHealth enemyHealth))
            {
                enemyHealth.GetDamage(_damage);
            }
        }
        Destroy(gameObject);

    }

    void Start()
    {
        StartCoroutine(Spawn());
    }
}
