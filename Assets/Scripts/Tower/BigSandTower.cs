using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSandTower : Tower
{
    private void Start()
    {
        ElementType = Element.BIGSAND;
    }

    public override Debuff GetDebuff()
    {
        return new BigSandDebuff(Target, DebuffDuration);
    }
}
