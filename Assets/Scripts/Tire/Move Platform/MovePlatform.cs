using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;
public class MovePlatform : MonoBehaviour
{
    public GameObject platform;
    private int spawnCount;
    public List<GameObject> platformsTire;
    private void Start()
    {
        spawnCount = platform.transform.childCount;
    }
    private void OnTriggerEnter(Collider other)
    {
        int i;
        for (i = 0; i < spawnCount; i++)
        {
            if (platformsTire[i] == null)
            {
                if (i!=0 && platformsTire[i-1]!=other.gameObject)
                {
                    platformsTire[i] = other.gameObject;
                    other.transform.DOMove(platform.transform.GetChild(i).position, 1.5f);
                }
                else if (i==0)
                {
                    platformsTire[i] = other.gameObject;
                    other.transform.DOMove(platform.transform.GetChild(i).position, 1.5f);
                }
                ChangeProperty(other.gameObject);
                break;
            }
        }        
    }
    public void ChangeProperty(GameObject gameObject)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.transform.localScale = StackableController.Instance.collectObject[1].transform.localScale;
    }
}
