using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolower : MonoBehaviour
{
    [SerializeField] private GameObject _followTarget;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.Lerp(transform.position, _followTarget.transform.position, Time.deltaTime * 2);
     
       
    }
}
