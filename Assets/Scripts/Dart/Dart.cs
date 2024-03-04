using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dart : Shoot
{
    private float dartValue;
    public TextMeshPro text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tire"))
        {
            dartValue = GetShootUp(dartValue, other.gameObject);
            text.text = dartValue.ToString(); 
        }
        else if (other.CompareTag("Player"))
        {
            Bar.Instance.BarValue(dartValue);
        }
    }
}
