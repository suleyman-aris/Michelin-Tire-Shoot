using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensRate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && GetComponent<LensShoot>().lensValue > 0)
        {
            TireVariable.Instance.tireRate += (GetComponent<LensShoot>().lensValue)/ 100;
        }
    }
}
