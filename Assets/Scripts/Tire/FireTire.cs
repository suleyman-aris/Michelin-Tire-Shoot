using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTire : MonoBehaviour
{
    private Rigidbody rb;
    public float fireDamage;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*TireVariable.Instance.bulletForce, ForceMode.Impulse);        
    }
    private void OnEnable()
    {
        fireDamage = StackableController.Instance.collectObject[1].GetComponent<TirePrivVar>().privDamage;
    }
}
