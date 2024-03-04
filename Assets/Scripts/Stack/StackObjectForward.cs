using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackObjectForward : MonoBehaviour
{
    public static StackObjectForward Instance;
    public GameObject character;
    private CharacterController characterController;
    public float _currentRunningSpeed = 5f;
    private void Awake()
    {
        Instance = Instance == null ? this : Instance;
    }
    private void Start()
    {
        characterController = character.GetComponent<CharacterController>();
    }
    void FixedUpdate()
    {
        _currentRunningSpeed = characterController._currentRunningSpeed;
        transform.position -= transform.up * _currentRunningSpeed * Time.deltaTime;
    }
}
