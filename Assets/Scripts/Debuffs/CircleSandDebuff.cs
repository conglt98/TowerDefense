using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSandDebuff : Debuff
{
    private float slowingFactor;

    private bool applied;

    public CircleSandDebuff(float slowingFactor, float duration, Monster target) : base(target, duration)
    {
        this.slowingFactor = slowingFactor;
    }
    public override void Update()
    {
        if (target != null)
        {
            if (!applied)
            {
                applied = true;
                target.Speed -= (target.MaxSpeed * slowingFactor) / 100;
            }
        }

        base.Update();
    }

    public override void Remove()
    {
        target.Speed = target.MaxSpeed;

        base.Remove();
    }
}
