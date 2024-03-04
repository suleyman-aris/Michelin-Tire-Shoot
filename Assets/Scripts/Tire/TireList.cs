using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireList : MonoBehaviour
{
    public static TireList Instance;
    public List<GameObject> tire;
    void Start()
    {
        Instance = Instance == null ? this : Instance;
    }
}
