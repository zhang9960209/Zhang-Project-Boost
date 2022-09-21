using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float pushThrust = 1000f;
    [SerializeField] float rotateThrust = 1f;
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
            rb.AddRelativeForce(Vector3.up * pushThrust * Time.deltaTime);
        }

        
    }

    void UserInputRotation()
    { 
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Turning Left");
            ChangeRotation(rotateThrust);
        }

        else if (Input.GetKey(KeyCode.D))
        { 
            Debug.Log("Turning Right");
            ChangeRotation(-rotateThrust);
        }
    }

    void ChangeRotation(float rotateThrust)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotateThrust * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
