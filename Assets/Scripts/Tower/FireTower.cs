using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTower : Tower
{

    private void Start()
    {
        ElementType = Element.FIRE;
    }
    public override Debuff GetDebuff()
    {
        return new FireDebuff(Target);
    }
}
