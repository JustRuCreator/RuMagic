using UnityEngine;

public abstract class SpellVariant : MonoBehaviour 
{
    [SerializeField] protected GameObject spellPrefab;
    [field:SerializeField] public SpellType SpellType { get; private set; }
    public abstract GameObject Cast(Vector2 position);
}