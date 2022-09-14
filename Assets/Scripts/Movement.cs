using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        UserInputThrust();
        UserInputRotation();
    }

    void UserInputThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Thrusting");
            rb.AddRelativeForce(Vector3.up);
        }

        
    }

    void UserInputRotation()
    { 
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Turning Left");
        }

        else if (Input.GetKey(KeyCode.D))
        { 
            Debug.Log("Turning Right");
        }
    }
}
