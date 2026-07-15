using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Element : MonoBehaviour
{
    [field: SerializeField] public DamageType DamageType { get; private set; }
    [field: SerializeField] public List<ParticleSystem> Visuals { get; private set; }
}
