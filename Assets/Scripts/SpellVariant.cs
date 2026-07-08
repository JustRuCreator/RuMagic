using UnityEngine;

public abstract class SpellVariant : MonoBehaviour 
{
    [SerializeField] protected GameObject spellPrefab;

    public abstract void Cast(Vector2 position);
}