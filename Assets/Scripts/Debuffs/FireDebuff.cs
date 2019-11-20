using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDebuff : Debuff
{
    public FireDebuff(Monster target):base(target)
    {

    }

    public override void Update()
    {
        target.TakeDamage(1, Element.FIRE);
        base.Update();
    }
}
