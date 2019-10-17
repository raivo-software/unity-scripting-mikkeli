using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 previousMousePosition;

    public float sensitivity = 0.1f;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            previousMousePosition = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 mouseDelta = Input.mousePosition - previousMousePosition;
            previousMousePosition = Input.mousePosition;

            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x - mouseDelta.y * sensitivity,
                transform.eulerAngles.y + mouseDelta.x * sensitivity,
                0
            );
        }
    }
}
