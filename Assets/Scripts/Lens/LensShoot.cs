using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LensShoot : Shoot
{
    public float lensValue;
    public float maxLensValue;
    public TextMeshPro textObject;
    private void Start()
    {
        textObject.text = lensValue.ToString();
        LensColor();
    }
    public void LensColor()
    {
        Color color;
        color.a = 0.5f;
        if (lensValue >= 0)
        {
            color = Color.green;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = color;
        }
        else
        {
            color = Color.red;
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = color;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tire"))
        {
            //lensValue += other.GetComponent<FireTire>().fireDamage;
            lensValue = GetShootUp(lensValue,other.gameObject);
            if (lensValue >= maxLensValue)
            {
                textObject.text = maxLensValue.ToString();
            }
            else
                textObject.text = lensValue.ToString();
            LensColor();
        }
    }
}
