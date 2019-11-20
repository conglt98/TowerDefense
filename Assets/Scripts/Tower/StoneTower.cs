using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTower : Tower
{
    [SerializeField]
    private float tickTime;

    [SerializeField]
    private StoneSplash splashPrefab;

    [SerializeField]
    private int splashDamage;

    public int SplashDamage { get => splashDamage; }
    public float TickTime { get => tickTime; }

    private void Start()
    {
        ElementType = Element.STONE;
    }

    public override Debuff GetDebuff()
    {
        return new StoneDebuff(splashDamage,tickTime,splashPrefab,DebuffDuration,Target);
    }
}
