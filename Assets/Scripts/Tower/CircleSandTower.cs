using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSandTower : Tower
{
    [SerializeField]
    private float slowingFactor;

    public float SlowingFactor { get => slowingFactor; set => slowingFactor = value; }

    private void Start()
    {
        ElementType = Element.CIRCLESAND;

        Upgrades = new TowerUpgrade[]
        {
            new TowerUpgrade(2,1,1,2,10),
            new TowerUpgrade(2,1,1,2,20),
        };
    }

    public override Debuff GetDebuff()
    {
        return new CircleSandDebuff(SlowingFactor,DebuffDuration,Target);
    }


    public override string GetStats()
    {
        if (NextUpgrade != null)
        {
            return string.Format("<color=#00ffffff>{0}</color>{1} \nSlowing factor: {2}% <color=#00ff00ff>+{3}</color>", "<size=20><b>Circle Sand</b></size>", base.GetStats(), SlowingFactor,NextUpgrade.SlowingFactor);
        }

        return string.Format("<color=#00ffffff>{0}</color>{1} \nSlowing factor: {2}%", "<size=20><b>Circle Sand</b></size>", base.GetStats(), SlowingFactor);
    }
}
