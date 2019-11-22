using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSandTower : Tower
{
    [SerializeField]
    private float slowingFactor;

    public float SlowingFactor { get => slowingFactor; set => slowingFactor = value; }

    private void Start()
    {
        ElementType = Element.CIRCLESAND;
    }

    public override Debuff GetDebuff()
    {
        return new CircleSandDebuff(SlowingFactor,DebuffDuration,Target);
    }
}
