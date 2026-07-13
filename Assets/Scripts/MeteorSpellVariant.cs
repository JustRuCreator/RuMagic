using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpellVariant : SpellVariant
{
    public override void Cast(Vector2 position)
    {
        Debug.Log("Meteor casted");
        Instantiate(spellPrefab, position, Quaternion.identity);
    }

  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
