using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireLife : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {Debug.Log("ba�lad�");
        StartCoroutine(ReturnBullet());
        
    }
    
    IEnumerator ReturnBullet()
    {
        yield return new WaitForSeconds(TireVariable.Instance.tireRange); // wait tire
        gameObject.SetActive(false);
    }
}
