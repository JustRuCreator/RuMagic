using System;
using UnityEngine;

public abstract class Element : MonoBehaviour
{
    [field: SerializeField] public DamageType DamageType { get; private set; }
}
