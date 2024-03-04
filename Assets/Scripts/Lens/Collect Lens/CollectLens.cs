using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CollectLens : MonoBehaviour
{
    public MovePlatform movePlatform;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int tireCount = movePlatform.platformsTire.Count(item => item != null);
            for (int i = 0; i < tireCount; i++)
            {
                StackableController.Instance.collectObject.Add(movePlatform.platformsTire[i]);
                movePlatform.platformsTire[i].transform.parent = StackObjectForward.Instance.transform;
                StackableController.Instance.ArrangeElements();          //StackableControllere's ArrangeElements
            }
        }
    }
}
