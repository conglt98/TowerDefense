using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneDebuff : Debuff
{
    private float timeSinceTick;
    
    private float tickTime;

    private StoneSplash splashPrefab;

    private int splashDamage;

    public StoneDebuff(int splashDamage, float tickTime, StoneSplash splashPrefab, float duration, Monster target) : base(target,duration)
    {
        this.splashDamage = splashDamage;
        this.tickTime = tickTime;
        this.splashPrefab = splashPrefab;
    }
    public override void Update()
    {
        if (target != null)
        {
            timeSinceTick += Time.deltaTime;

            if (timeSinceTick>= tickTime)
            {
                timeSinceTick = 0;
                Splash();
            }
        }

        base.Update();
    }
    private void Splash()
    {
        StoneSplash tmp = GameObject.Instantiate(splashPrefab, target.transform.position,Quaternion.identity);

        tmp.Damage = splashDamage;

        Physics2D.IgnoreCollision(target.GetComponent<Collider2D>(),tmp.GetComponent<Collider2D>());
    }
}
