using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TirePrivVar : MonoBehaviour
{
    public float privDamage;
    private void Start()
    {
        if (transform.parent.GetComponent<PlatformDamage>())
            transform.parent.GetComponent<PlatformDamage>().setDamage += TirePrivVar_setDamage;
        privDamage = TireVariable.Instance.damage;
        DamageText();
    }

    private void TirePrivVar_setDamage(float obj)
    {
        privDamage = obj;
        DamageText();
    }
    public void DamageText()
    {
        transform.GetChild(0).GetComponent<TextMeshPro>().text = privDamage.ToString();
    }
}
