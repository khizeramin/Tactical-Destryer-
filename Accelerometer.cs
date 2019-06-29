using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public float speedometer;
    private float friction;
     
    void Start()
    { 
        friction = 0.01f;
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vectorMotion = Input.acceleration;
        Vector3 movement = new Vector3(vectorMotion.x, 0.0f, -vectorMotion.y);
        //transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z*velocityZ*Time.deltaTime);
        //GetComponent<Rigidbody>().velocity = new Vector3(velocityX * Input.acceleration.x * 0.07f, 0, velocityZ * Input.acceleration.z * 0.07f);
        GetComponent<Rigidbody>().velocity = movement * speedometer;
        
    }   
}
