using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPrint : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    public virtual void ButtonPrint(float amount)
    {
        if (amount >= 1000000000)
        {
            float money = (float)amount / 1000000000;
            //transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = money.ToString("F1") + " b";
            textUI.text = money.ToString("F1") + " b";
        }
        else if (amount >= 1000000)
        {
            float money = (float)amount / 1000000;
            //transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = money.ToString("F1") + " m";
            textUI.text = money.ToString("F1") + " m";
        }
        else if (amount >= 1000)
        {
            float money = (float)amount / 1000;
            //transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = money.ToString("F1") + " k";
            textUI.text = money.ToString("F1") + " k";
        }
        else
        {
            //transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = amount.ToString();
            textUI.text = amount.ToString();
        }
    }
}
