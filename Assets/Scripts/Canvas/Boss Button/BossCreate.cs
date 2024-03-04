using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCreate : MonoBehaviour
{
    public GameObject bossTire;
    public Transform spawnPoint;

    public void BossSpawn()
    {
        Instantiate(bossTire, spawnPoint.position, bossTire.transform.rotation);
    }
}
