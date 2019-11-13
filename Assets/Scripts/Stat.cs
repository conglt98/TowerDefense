using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
class Stat
{
    [SerializeField]
    private BarScript bar;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float currentVal;

    public float CurrentValue { get => currentVal; set => currentVal = value; }
    public float MaxVal { get => maxVal; set => maxVal = value; }
}
