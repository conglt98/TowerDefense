using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTower : Tower
{
    private void Start()
    {
        ElementType = Element.STONE;
    }

    public override Debuff GetDebuff()
    {
        return new StoneDebuff(Target);
    }
}
