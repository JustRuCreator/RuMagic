using UnityEngine;

public class MeteorSpellVariant : SpellVariant
{
    public override GameObject Cast(Vector2 position)
    {
        Debug.Log("Meteor casted");
        return Instantiate(spellPrefab, position, Quaternion.identity);
    }
}
