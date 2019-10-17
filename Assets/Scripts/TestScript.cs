using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject Sphere;
    
    void Update()
    {
        HandleInputs();
    }

    private void HandleInputs()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Sphere.SetActive(!Sphere.activeInHierarchy);
        }

        SphereController sphereController = Sphere.GetComponent<SphereController>();
        if(Input.GetMouseButtonDown(1) && sphereController == null)
        {
            Sphere.AddComponent<SphereController>();
        }

        if(Input.GetKeyDown(KeyCode.I))
        {
            GameObject newSphere = GameObject.Instantiate(Sphere);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            Destroy(Sphere);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            GameObject clonedSphere = GameObject.Find("Sphere(Clone)");
            Sphere = clonedSphere;
        }
    }
}
