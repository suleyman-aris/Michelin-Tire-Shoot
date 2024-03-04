using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : TextPrint
{
    public static MoneyManager Instance;
    public float currentMoney;
    public float thisLevelMoney;
    private void Awake()
    {
        Instance = Instance == null ? this : Instance;
    }

    public void AddMoney(float amount)
    {
        currentMoney += amount;
        ButtonPrint(currentMoney);
    }
    public void SubtractMoney(float amount)
    {
        if (currentMoney >= amount)
        {
            currentMoney -= amount;
            ButtonPrint(currentMoney);
        }
    }
}
