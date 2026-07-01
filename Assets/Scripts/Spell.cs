using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
   private ISpellVariant _spellVariant;
   private IElement _element;
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    
    public void Initialize(ISpellVariant spellVariant, IElement element)
    {
        _spellVariant = spellVariant;
        _element = element;
    }
}
