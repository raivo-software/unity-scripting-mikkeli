using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    private bool isDragging = false;
    private float distanceToCamera;

    void Update()
    {
        TryMove();
    }

    private void TryMove()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            bool raycastSuccesful = Physics.Raycast(ray, out raycastHit);
            if (raycastSuccesful)
            {
                if (raycastHit.transform == transform)
                {
                    isDragging = true;
                    distanceToCamera = (transform.position - Camera.main.transform.position).magnitude;
                }
            }
        }

        if (Input.GetMouseButtonUp(1) && isDragging)
            isDragging = false;

        if(isDragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 newPosition = ray.GetPoint(distanceToCamera);
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }
}
