using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float speed = 20;
    private readonly float turnSpeed = 25;

    private float HorizontalInput
    {
        get => Input.GetAxis("Horizontal");
    }

    private float VerticalInput
    {
        get => Input.GetAxis("Vertical");
    }
    
    // Update is called once per frame
    void Update()
    {
        ControllerHandler();
    }

    private void ControllerHandler()
    { 
        if (VerticalInput == 0) return;
        transform.Translate(VerticalInput * speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(HorizontalInput * turnSpeed * Time.deltaTime * Vector3.up); 
    }
}
