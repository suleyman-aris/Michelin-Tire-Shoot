using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   public float GetShootUp(float damage, GameObject other)
    {
        damage += other.GetComponent<FireTire>().fireDamage;
        DestroyTire(other.gameObject);
        return damage;
    }
    public float GetShootDown(float damage, GameObject other)
    {
        damage -= other.GetComponent<FireTire>().fireDamage;
        DestroyTire(other.gameObject);
        return damage;
    }
    public void DestroyTire(GameObject other)
    {
        other.gameObject.SetActive(false);
    }
}
