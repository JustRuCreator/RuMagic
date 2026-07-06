using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpellVariant : MonoBehaviour, ISpellVariant
{
    public void Cast(Vector2 position)
    {
        Debug.Log("Meteor casted");
    }

  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
