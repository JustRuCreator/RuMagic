using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private float _time;
    private bool _canDamage = true;

    private IEnumerator Cooldown()
    {
        _canDamage = false;
        yield return new WaitForSeconds (0.25f);
        _canDamage = true;
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(_time);
        Destroy(gameObject); 
    }
    private void start()
    {
        StartCoroutine(Destroy());
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_canDamage == false)
            return;
           
        if(collision.TryGetComponent(out EnemyHealth enemyHealth))
        {
            Debug.Log(collision.gameObject.name);
            enemyHealth.GetDamage(_damage);
            StartCoroutine(Cooldown());
        }
    }
}
