using UnityEngine;

public class ElementFire : MonoBehaviour, IElement
{
    [SerializeField] private DamageType _damageType;
    public DamageType DamageType => _damageType;
}
