using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpellVariant : SpellVariant
{
    public override GameObject Cast(Vector2 position)
    {
        Debug.Log("Rain casted");
        return Instantiate(spellPrefab, position, Quaternion.identity);
    }
}
