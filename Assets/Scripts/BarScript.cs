using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    [SerializeField]
    private Image content;

    [SerializeField]
    private Text valueText;

    [SerializeField]
    private float lerpSpeed;

    private float fillAmount;

    [SerializeField]
    private bool lerpColors;

    [SerializeField]
    private Color fullColor;

    [SerializeField]
    private Color lowColor;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            fillAmount = Map(value, 0, MaxValue, 0, 1);
           
        }
    }

    private float currentTime;

    void Start()
    {
        if (lerpColors)
        {
            content.color = fullColor;
        }
    }

    void Update()
    {
        HandleBar();
    }

    private void HandleBar()
    {

        if (fillAmount != content.fillAmount)
        {
            Debug.Log("change amount...");
            content.fillAmount = Mathf.Lerp(content.fillAmount,fillAmount,Time.deltaTime*lerpSpeed);
        }

        if (lerpColors)
        {
            content.color = Color.Lerp(lowColor, fullColor, fillAmount);

        }
    }

    private float Map(float value, float inMin, float inMax, float outMin,float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;        
    }
}
