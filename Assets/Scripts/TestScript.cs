using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject Sphere;

    public float speedMultiplier = 1;
    
    void Update()
    {
        HandleInputs();
    }

    private void HandleInputs()
    {
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * speedMultiplier * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speedMultiplier * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speedMultiplier * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speedMultiplier * Time.deltaTime);
        }
    }
}
