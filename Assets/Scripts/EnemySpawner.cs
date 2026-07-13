using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
   
    void Start()
    {
        
    }

 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
           // Instantiate(_enemy, )
        }
    }
}
