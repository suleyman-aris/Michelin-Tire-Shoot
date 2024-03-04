using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensRange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && GetComponent<LensShoot>().lensValue > 0)
        {
            TireVariable.Instance.tireRange += (GetComponent<LensShoot>().lensValue)/100;
        }
    }
}
