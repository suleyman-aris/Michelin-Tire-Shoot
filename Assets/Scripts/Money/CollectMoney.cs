using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMoney : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MoneyManager.Instance.thisLevelMoney += MoneyVar.Instance.moneyVar;
            MoneyManager.Instance.AddMoney(MoneyVar.Instance.moneyVar);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MoneyManager.Instance.thisLevelMoney += MoneyVar.Instance.moneyVar;
            MoneyManager.Instance.AddMoney(MoneyVar.Instance.moneyVar);
        }
    }
}
