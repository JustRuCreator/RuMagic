using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float _MaxHP;
    private float _HP;
    void Start()
    {
        _HP = _MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyAttack enemyAttack))
        {
            _HP -= enemyAttack.Damage;
            if (_HP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
