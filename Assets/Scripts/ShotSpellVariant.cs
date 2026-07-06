using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpellVariant : MonoBehaviour, ISpellVariant
{
    public void Cast(Vector2 position)
    {
        Debug.Log("Shot casted");
    }

   
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
