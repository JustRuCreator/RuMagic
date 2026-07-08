using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
   private SpellVariant _spellVariant;
   private Element _element;   
    public void Initialize(SpellVariant spellVariant, Element element, Vector2 position)
    {
        _spellVariant = spellVariant;
        _element = element;
        _spellVariant.Cast(position);
    }
}
