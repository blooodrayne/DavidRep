using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerSphereMovement2 : MonoBehaviour
{
    public float speed;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
       float moveVertical = Input.GetAxis("Vertical"); 

       Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

       playerRb.AddForce(movement * speed);
    }
}
