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
        GameObject spell = _spellVariant.Cast(position);
        ParticleSystem effect = Instantiate(_element.Visuals[(int)spellVariant.SpellType]);
        effect.transform.position = spell.transform.position;
        if (spellVariant.SpellType == SpellType.Shot)
        {
            effect.transform.Translate(0, 0, -8);
            effect.transform.up = -(position - (Vector2)spell.transform.position);
        }
        effect.transform.parent = spell.transform;
    }
}
