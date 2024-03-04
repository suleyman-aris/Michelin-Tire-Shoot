using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class PlatformDamage : Shoot
{
    private GameObject tire;
    public float takeDamage;
    public TextMeshPro textObject;
    public event Action zeroDamage;
    public event Action<float> setDamage;

    private void Start()
    {
        tire = transform.GetChild(0).gameObject;
        textObject.text = takeDamage.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tire"))
        {
            //takeDamage += other.GetComponent<FireTire>().fireDamage;
            takeDamage = GetShootUp(takeDamage, other.gameObject);
            textObject.text = takeDamage.ToString();
        }
        else if (other.gameObject.CompareTag("Player") && takeDamage >= 0)
        {
            tire.transform.parent = null;
            zeroDamage?.Invoke();           //MoveBand's Move
            setDamage?.Invoke(takeDamage);          // TirePrivVar's  
            gameObject.SetActive(false);
        }
    }
}
