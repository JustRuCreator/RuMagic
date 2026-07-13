using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float _maxHp;
    private float _hp;
    void Start()
    {
        _hp = _maxHp;
    }

    
    public void GetDamage(float damage)
    {
        _hp -= damage;

        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
