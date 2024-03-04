using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarDamage : Shoot
{
    public TextMeshPro textObject;
    public float takeDamage;

    private void Start()
    {
        textObject.text = takeDamage.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tire"))
        {
            takeDamage = GetShootDown(takeDamage, other.gameObject);
        }
        else if (other.gameObject.CompareTag("BossTire"))
        {
            takeDamage = 0;
            other.gameObject.SetActive(false);
        }
        if (takeDamage <= 0)
        {
            gameObject.SetActive(false);
        }
        textObject.text = takeDamage.ToString();
    }
}
