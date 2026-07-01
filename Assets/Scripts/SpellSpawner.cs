using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpellSpawner : MonoBehaviour
{
    [SerializeField] private string _input;
    
    private List<IElement> _allElements;
    private List<ISpellVariant> _allSpells;

    private void Awake()
    {
        IElement element = new GameObject().AddComponent<ElementFire>();
        _allElements.Add(element);
        element = new GameObject().AddComponent<ElementWater>();
        _allElements.Add(element);
        element = new GameObject().AddComponent<ElementEarth>();
        _allElements.Add(element);
        ISpellVariant spellVariant = new GameObject().AddComponent<MeteorSpellVariant>();
        _allSpells.Add(spellVariant);
        spellVariant = new GameObject().AddComponent<RainSpellVariant>();
        _allSpells.Add(spellVariant);
        spellVariant = new GameObject().AddComponent<ShotSpellVariant>();
        _allSpells.Add(spellVariant);
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
