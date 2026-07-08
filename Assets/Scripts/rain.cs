using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    [SerializeField] private int _damage;
    private bool _canDamage = true;

    private IEnumerator Cooldown()
    {
        _canDamage = false;
        yield return new WaitForSeconds (0.25f);
        _canDamage = true;
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_canDamage == false)
            return;
        StartCoroutine(Cooldown());

            Debug.Log(collision.gameObject.name);
        if(collision.TryGetComponent(out EnemyHealth enemyHealth))
        {
            enemyHealth.GetDamage(_damage);
        }
    }
}
