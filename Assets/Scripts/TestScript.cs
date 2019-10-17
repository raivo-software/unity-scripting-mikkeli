using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject Sphere;

    public float speedMultiplier = 1;

    private Vector3 movementDirection;
    
    void Update()
    {
        HandleInputs();
        Move();
    }

    private void Move()
    {
        if (movementDirection != null)
        {
            Vector3 newPosition = transform.position + (movementDirection * Time.deltaTime * speedMultiplier);
            if (newPosition.x >= 0)
                transform.position = newPosition;
        }
    }

    private void HandleInputs()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            movementDirection = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            movementDirection = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            movementDirection = Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            movementDirection = Vector3.right;
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            movementDirection = Vector3.zero;
        }
    }
}
