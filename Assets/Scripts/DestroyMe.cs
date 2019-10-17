using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    public Collider Cube;

    private void OnTriggerEnter(Collider other)
    {
        if (other == Cube)
            Destroy(gameObject);
    }

    private void Update()
    {
        TryRaycast();
    }

    private void TryRaycast()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            bool raycastSuccesful = Physics.Raycast(ray, out raycastHit);
            if(raycastSuccesful)
            {
                if(raycastHit.transform == transform)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
