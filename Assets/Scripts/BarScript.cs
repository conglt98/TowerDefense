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

    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
