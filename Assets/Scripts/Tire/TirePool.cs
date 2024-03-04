using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirePool : MonoBehaviour
{
    public static TirePool Instance;
    public Transform spawnPoint;
    private float nextFireTime;
    public bool poolStop;
    private void Awake()
    {
        Instance = Instance == null ? this : Instance;
    }
    void Update()
    {
        if (Time.time >= nextFireTime && !poolStop)
        {
            FireBullet();
            StackableController.Instance.StackPool();
            nextFireTime = Time.time + 1f / TireVariable.Instance.tireRate; // then fire time settings
        }
    }

    void FireBullet()
    {
        foreach (GameObject tire in TireList.Instance.tire)
        {
            if (!tire.activeInHierarchy) // pool's first visiable tire
            {
                tire.SetActive(true);
                tire.transform.position = spawnPoint.position;
                //StartCoroutine(ReturnBullet(tire));
                break;
            }
        }
    }

    //IEnumerator ReturnBullet(GameObject bullet)
    //{
    //    yield return new WaitForSeconds(TireVariable.Instance.tireRange); // wait tire
    //    bullet.SetActive(false); 
    //}
}
