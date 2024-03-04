using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController.Instance._currentRunningSpeed = 0;
            TirePool.Instance.poolStop= true;
        }
    }
}
