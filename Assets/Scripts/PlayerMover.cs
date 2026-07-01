using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       float x = Input.GetAxis("Horizontal");
       float y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            x = x * 2;
            y = y * 2;
        }
       
       _rb.velocity = (new Vector2(x, y)*5);
    }
}
