using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerBtn : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPerfab;

    [SerializeField]
    private Sprite sprite;

    [SerializeField]
    private int price;

    [SerializeField]
    private Text priceTxt;

    public GameObject TowerPerfab { get => towerPerfab;}
    public Sprite Sprite { get => sprite;}
    public int Price { get => price; }

    private void Start()
    {
        priceTxt.text = Price + "$";
        GameManager.Instance.Changed += new CurrencyChanged(PriceCheck);
    }

    private void PriceCheck()
    {
        if (price <= GameManager.Instance.Currency)
        {
            GetComponent<Image>().color = Color.white;
            priceTxt.color = Color.white;
        }
        else
        {
            GetComponent<Image>().color = Color.grey;
            priceTxt.color = Color.grey;
        }
    }

    public void ShowInfo(string type)
    {
        string tooltip = string.Empty;

        switch (type)
        {
            case "Big Sand":
                BigSandTower bigSand = towerPerfab.GetComponentInChildren<BigSandTower>();
                tooltip = string.Format("<color=#add8e6ff><size=20><b>Big Sand</b></size></color>\nDamage: {0} \nProc: {1}% \nDebuff duration: {2}sec \nHas a chance to stun the target",bigSand.Damage,bigSand.Proc,bigSand.DebuffDuration);
                break;
            case "Circle Sand":
                CircleSandTower circleSand = towerPerfab.GetComponentInChildren<CircleSandTower>();
                tooltip = string.Format("<color=#00ffffff><size=20><b>Circle Sand</b></size></color>\nDamage: {0} \nProc: {1}% \nDebuff duration: {2}sec \nSlowing factor: {3}% \nHas a chance to slow down the target",circleSand.Damage,circleSand.Proc,circleSand.DebuffDuration,circleSand.SlowingFactor);

                break;
            case "Fire":
                FireTower fire = towerPerfab.GetComponentInChildren<FireTower>();

                tooltip = string.Format("<color=#ffa500ff><size=20><b>Fire</b></size></color>\nDamage: {0} \nProc: {1}% \nDebuff duration: {2}sec \nTick time: {3}sec \nTick damage: {4} \nCan apply a DOT to the target",fire.Damage,fire.Proc,fire.DebuffDuration,fire.TickTime,fire.TickDamage);

                break;
            case "Stone":
                StoneTower stone = towerPerfab.GetComponentInChildren<StoneTower>();

                tooltip = string.Format("<color=#00ff00ff><size=20><b>Stone</b></size></color>\nDamage: {0} \nProc: {1}% \nDebuff duration: {2}sec \nTick time: {3}sec \nSlash damage: {4} \nCan apply stone trapping",stone.Damage,stone.Proc,stone.DebuffDuration,stone.TickTime,stone.SplashDamage);

                break;
        }

        GameManager.Instance.SetTooltipText(tooltip);
        GameManager.Instance.ShowStats();
    }
}
