using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    public float playerNormalSpeed; 
    private float playerSprintSpeed; 
    private float playerSpeed; 

    Rigidbody2D myRigidbody; 

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        playerSprintSpeed = playerNormalSpeed * 1.5f; 
    }


    private void FixedUpdate()
    {
        MovingPlayer(); 
    }

    private void MovingPlayer()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        myRigidbody.velocity = new Vector2(horizontal, vertical) * playerSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = playerSprintSpeed;
        }
        else
            playerSpeed = playerNormalSpeed; 
    }


}
