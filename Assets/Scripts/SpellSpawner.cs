using System.Collections.Generic;
using UnityEngine;

public class SpellSpawner : MonoBehaviour
{
    [SerializeField] private string _input;

    private List<IElement> _allElements = new List<IElement>();
    private List<ISpellVariant> _allSpells = new List<ISpellVariant>();

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
    public void SpawnSpell()
    {
        Spell spell = new GameObject("New Spell").AddComponent<Spell>();
        int index = _input.IndexOf(' ');
        IElement element = null;
        ISpellVariant spellVariant = null;
        if (index == -1)
            return;

        string elementName = _input.Substring(0, index);
        string spellName = _input.Substring(index + 1);


        for (int i = 0; i < _allElements.Count; i++)
        {
            if (_allElements[i].GetType().FullName.ToLower().Contains(elementName.ToLower()))
            {
                element = _allElements[i];
            }
        }
        for (int i = 0; i < _allSpells.Count; i++)
        {
            if (_allSpells[i].GetType().FullName.ToLower().Contains(spellName.ToLower()))
            {
                spellVariant = _allSpells[i];
            }
        }
        spell.Initialize(spellVariant, element, Vector3.zero);


    }
    void Start()
    {
        SpawnSpell();
    }


    void Update()
    {

    }
}
