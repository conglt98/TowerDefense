﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSandTower : Tower
{
    private void Start()
    {
        ElementType = Element.CIRCLESAND;
    }

    public override Debuff GetDebuff()
    {
        return new CircleSandDebuff(Target);
    }
}
