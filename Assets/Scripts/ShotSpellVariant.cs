using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpellVariant : SpellVariant
{   
    public override void Cast(Vector2 position)
    {
       
        Debug.Log("Shot casted");

        GameObject spell = Instantiate(spellPrefab, transform.position, Quaternion.identity);

        if (spell.TryGetComponent(out Shot shot))
        {
            shot.Move(position);
        }
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
