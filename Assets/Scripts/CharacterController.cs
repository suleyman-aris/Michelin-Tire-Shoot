using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public static CharacterController Instance;

    public float newX;
    public float limitX;
    public float xSpeed;
    public float _currentRunningSpeed;

    private Rigidbody rb;

    private void Start()
    {
        Instance = Instance == null ? this : Instance;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        newX = 0;
        float touchXDelta = 0;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
            StackableController.Instance.MoveObjectElement();
        }
        else if (Input.GetMouseButton(0))
        {
            touchXDelta = Input.GetAxis("Mouse X");
            StackableController.Instance.MoveObjectElement();
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            StackableController.Instance.MoveOrigin();

        else if (Input.GetMouseButtonUp(0))
            StackableController.Instance.MoveOrigin();

        newX = transform.localPosition.x + xSpeed * touchXDelta * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);

        Vector3 newPosition = new Vector3(newX, transform.localPosition.y, transform.localPosition.z + _currentRunningSpeed * Time.deltaTime);
        rb.MovePosition(newPosition);
    }
}
