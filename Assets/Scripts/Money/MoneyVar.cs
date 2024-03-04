using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyVar : MonoBehaviour
{
    public static MoneyVar Instance;

    public float moneyVar;
    public float moneyInrease = 0.1f;
    private void Awake()
    {
        Instance = Instance == null ? this : Instance;
    }

}
