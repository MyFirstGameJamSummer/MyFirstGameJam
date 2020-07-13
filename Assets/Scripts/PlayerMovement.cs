using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool isWalking = false;
    private bool isAttacking = false;
    private Rigidbody2D rb2d;
   [SerializeField] private float speed;
   private float horizontalInput;
   private float verticalInput;
   private Vector2 playerVelocity;
   

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerVelocity = Vector2.zero;
    }


    
    void FixedUpdate()
    {
        playerVelocity = Vector2.zero;
        
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0)
        {
            
            playerVelocity.x = horizontalInput * speed;
            isWalking = true;
        }

        if (verticalInput != 0)
        {
            playerVelocity.y = verticalInput * speed;
        }

        rb2d.velocity = playerVelocity;


    }



    void Flip()
    {
        Vector2 flipScale = transform.localScale;

        flipScale.x *= -1;

        transform.localScale = flipScale;




    }
        
}
