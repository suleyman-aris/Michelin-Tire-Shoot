using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLens : MonoBehaviour
{
    public Button bossButton;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Bar.Instance.bigTile)
        {
            bossButton.gameObject.SetActive(true); 
        }
    }
}
