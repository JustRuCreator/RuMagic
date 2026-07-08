using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpellVariant : SpellVariant
{
    public override void Cast(Vector2 position)
    {
        Debug.Log("Shot casted");
        //Instantiate(spellPrefab, position, Quaternion.identity);
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
