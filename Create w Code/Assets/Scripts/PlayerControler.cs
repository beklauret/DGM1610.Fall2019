using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
        //Game private vertical
    private float speed = 20f;
    private float turnSpeed = 15f;
    private float horizontalInput;
    private float forwardInput;

  
    // Update is called once per frame
    void Update()
    {
            //This controls the movement of the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
            //This makes the vehicle move horizantal and vertical
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
