using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade 
{
    public int Price { get; set; }

    public int Damage { get; set; }

    public float DebuffDuration { get; set; }

    public float ProcChance { get; set; }

    public float SlowingFactor { get; set; }

    public float TickTime { get; set; }

    public int SpecialDamage { get; set; }

    public TowerUpgrade(int price, int damage, float debuffduration, float procChange)
    {
        this.Damage = damage;
        this.DebuffDuration = debuffduration;
        this.ProcChance = procChange;
        this.Price = price;
    }

    public TowerUpgrade(int price, int damage, float debuffduration, float procChange, float slowingFactor)
    {
        this.Damage = damage;
        this.DebuffDuration = debuffduration;
        this.ProcChance = procChange;
        this.SlowingFactor = slowingFactor;
        this.Price = price;
    }

    public TowerUpgrade(int price, int damage, float debuffduration, float procChange, float tickTime, int specialDamage)
    {
        this.Damage = damage;
        this.DebuffDuration = debuffduration;
        this.ProcChance = procChange;
        this.TickTime = tickTime;
        this.SpecialDamage = specialDamage;
        this.Price = price;
    }
}
