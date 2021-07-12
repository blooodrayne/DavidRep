using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementAfterPlayer : MonoBehaviour
{

    public float angularSpeed = 1f;
    public Transform target;
    private float angleY = 3f;

    private void Start()
    {
        angleY = transform.rotation.y;
    }

    private void LateUpdate(){
        if(Input.GetMouseButton(0)) 
        {
            //angleY += angularSpeed;
            transform.position = target.transform.position;
            transform.eulerAngles += angularSpeed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);
        }
        //if(Input.GetAxis(KeyCode.X)) angleY += angularSpeed;

        //transform.position = target.transform.position;
        //transform.rotation = Quaternion.Euler(0, angleY,0);
    }

}
