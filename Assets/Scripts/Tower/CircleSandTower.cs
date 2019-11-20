using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSandTower : Tower
{
    [SerializeField]
    private float slowingFactor;

    private void Start()
    {
        ElementType = Element.CIRCLESAND;
    }

    public override Debuff GetDebuff()
    {
        return new CircleSandDebuff(slowingFactor,DebuffDuration,Target);
    }
}
