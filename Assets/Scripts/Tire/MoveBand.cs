using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveBand : MonoBehaviour
{
    public PlatformDamage platformDamage;
    public Transform band;
    void Start()
    {
        platformDamage.zeroDamage += Move;
    }

    private void Move()
    {
        Vector3 newPos = new Vector3(band.position.x, band.position.y + 1f, transform.position.z);
        transform.DOMove(newPos, 1f);
        Preparation();
    }

    private void Preparation()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().isTrigger = false;
    }
}
