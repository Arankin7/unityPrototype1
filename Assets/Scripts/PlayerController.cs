using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float truckSpeed = 20;
    private float turnSpeed = 90;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward along the Z axis.  
        transform.Translate(Vector3.forward * Time.deltaTime * truckSpeed * forwardInput);

        // Rotates the car on the Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }

}
