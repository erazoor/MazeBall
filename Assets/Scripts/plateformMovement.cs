using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    public float rotationSpeed = 35f;
    
    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }
    
    public void Reset()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}
