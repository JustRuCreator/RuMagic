using System.Collections.Generic;
using UnityEngine;

public class SpellSpawner : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private string _input;

    [SerializeField] private List<Element> _allElements = new List<Element>();
    [SerializeField] private List<SpellVariant> _allSpells = new List<SpellVariant>();

    private void Awake()
    {
        Element element = new GameObject().AddComponent<ElementFire>();
        _allElements.Add(element);
        element = new GameObject().AddComponent<ElementWater>();
        _allElements.Add(element);
        element = new GameObject().AddComponent<ElementEarth>();
        _allElements.Add(element);
    }
    public void SpawnSpell()
    {
        Spell spell = new GameObject("New Spell").AddComponent<Spell>();
        int index = _input.IndexOf(' ');
        Element element = null;
        SpellVariant spellVariant = null;
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

        Vector3 worldMousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        spell.Initialize(spellVariant, element, worldMousePos);
        Invoke("SpawnSpell", 10f);


    }
    void Start()
    {
        SpawnSpell();
    }


    void Update()
    {

    }
}
