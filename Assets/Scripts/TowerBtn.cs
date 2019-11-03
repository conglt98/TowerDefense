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
    }
}
