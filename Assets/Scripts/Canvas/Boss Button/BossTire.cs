using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTire : MonoBehaviour
{
    Rigidbody rb;
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * (TireVariable.Instance.bulletForce +3), ForceMode.Impulse);
    }
}
