using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireVariable : MonoBehaviour
{
    public static TireVariable Instance;

    public float tireRate = 2;
    public float tireRange = 1.5f;
    public float bulletForce = 8;
    public float damage = 0.5f;

    private void Awake()
    {
        Instance = Instance == null ? this : Instance;
    }
}
