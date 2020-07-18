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
    public Animator animator;
    public GameObject Hero;
    private Direction lastDirection;
    private Direction newDirection;

    private Vector2 flipScale;
    enum Direction
    {
        Left,
        Right,
        
    }
    
   

    // Start is called before the first frame update
    void Start()
    {

        newDirection = Direction.Right;
        lastDirection = Direction.Right;
        rb2d = GetComponent<Rigidbody2D>();
        playerVelocity = Vector2.zero;
        animator.GetComponent<Animator>();
    }




    void FixedUpdate()
    {
        lastDirection = newDirection;
        playerVelocity = Vector2.zero;
        isWalking = false;

        
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
            isWalking = true;
        }

        
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("iswalking", true);
            animator.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            newDirection = Direction.Right; 
            animator.SetBool("iswalking", true);
            animator.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            newDirection = Direction.Left;
            animator.SetBool("iswalking", true);
            animator.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("iswalking", true);
            animator.SetBool("isIdle", false);
        } else
        {
            animator.SetBool("iswalking", false);
            animator.SetBool("isIdle", true);
        }
        
        Flip(newDirection,lastDirection);
        rb2d.velocity = playerVelocity;


    }



    void Flip(Direction _new, Direction _last)
    {
        if ( _new != _last )
        {
            flipScale = transform.localScale;
            flipScale.x *= -1;
            transform.localScale = flipScale;
        }
    }
}

