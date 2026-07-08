using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpellVariant : SpellVariant
{
    [SerializeField] private GameObject _rain;
    public override void Cast(Vector2 position)
    {
        Debug.Log("Rain casted");
        Instantiate(spellPrefab, position, Quaternion.identity);
    }

   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
