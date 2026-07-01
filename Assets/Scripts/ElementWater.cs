using UnityEngine;

public class ElementWater : MonoBehaviour, IElement
{
    [SerializeField] private DamageType _damageType;
    public DamageType DamageType => _damageType;
}