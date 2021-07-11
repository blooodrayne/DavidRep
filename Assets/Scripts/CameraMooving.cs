using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMooving : MonoBehaviour
{
   
   //public Vector2 direction = new Vector2 (2f, 0f);
   [SerializeField] private float cameraSpeed = 5f;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(cameraSpeed * Time.deltaTime, 0,0);
    }
}
