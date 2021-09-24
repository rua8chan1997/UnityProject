using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontallInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle foward
        forwardInput = Input.GetAxis("Vertical");
        horizontallInput = Input.GetAxis("Horizontal");
        // Moves the car forward base on vertical input
        transform.Translate(Vector3.forward*Time.deltaTime* speed * forwardInput);

        // rotate the car base on horizontal input
        /*transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontallInput);*/
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontallInput);
    }
}
