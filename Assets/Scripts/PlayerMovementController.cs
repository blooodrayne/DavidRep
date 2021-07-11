using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    public float playerMovementSpeed = 20f;
    private Rigidbody2D playerRigidbody;

    private bool spriteLookRight = true;

    void Start()
    {
        playerRigidbody = GetComponent <Rigidbody2D> ();

    }


    void FixedUpdate()
    {
        
        

        float player_Y_Movement = Input.GetAxis ("Vertical");
            //Единовременно работает либо одно, либо другое
           // playerRigidbody.MovePosition(playerRigidbody.position. + Vector2.down * player_Y_Movement * playerMovementSpeed * Time.deltaTime); 
            float player_X_Movement = Input.GetAxis ("Horizontal");
           // playerRigidbody.MovePosition(playerRigidbody.position + Vector2.right * player_X_Movement * playerMovementSpeed * Time.deltaTime);

             Vector3 vectorPlayerMovement = new Vector3 (player_X_Movement, player_Y_Movement,0.0f);
     
        playerRigidbody.AddForce(vectorPlayerMovement * playerMovementSpeed);
    
       /* 
        if (GetComponent<Rigidbody>().velocity.x != 0) 
        {
            GetComponent<Rigidbody>().velocity.y = 0;
        }
        
        else if (GetComponent<Rigidbody>().velocity.y != 0) 
        {    
            GetComponent<Rigidbody>().velocity.x = 0;
        }*/
        

    }
}
