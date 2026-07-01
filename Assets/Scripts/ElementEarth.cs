using UnityEngine;

public class ElementEarth : MonoBehaviour, IElement
{
    [SerializeField] private DamageType _damageType;

    public DamageType DamageType => _damageType;
}