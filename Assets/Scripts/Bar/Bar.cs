using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public static Bar Instance;
    public bool bigTile=false;
    private float barValue;
    public Image barImage;
    private void Awake()
    {
        Instance = Instance == null ? this : Instance; 
        if (barImage == null)
        {
            barImage = GetComponent<Image>();
        }
    }

    public void BarValue(float value)
    {
        barValue += value/25;
        barImage.fillAmount = barValue;
        if (barValue >= 1)
        {
            bigTile = true;
        }
    }
}
