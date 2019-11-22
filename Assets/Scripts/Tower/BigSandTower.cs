using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSandTower : Tower
{
    private void Start()
    {
        ElementType = Element.BIGSAND;

        Upgrades = new TowerUpgrade[]
        {
            new TowerUpgrade(2,2,1,2),
            new TowerUpgrade(5,3,1,2),
        };
    }

    public override Debuff GetDebuff()
    {
        return new BigSandDebuff(Target, DebuffDuration);
    }

    public override string GetStats()
    {
        if (NextUpgrade != null)
        {
            return string.Format("<color=#add8e6ff>{0}</color>{1}", "<size=20><b>Big Sand</b></size>", base.GetStats());
        }

        return string.Format("<color=#add8e6ff>{0}</color>{1}", "<size=20><b>Big Sand</b></size>", base.GetStats());
    }
}
