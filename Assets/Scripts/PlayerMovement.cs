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
   

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerVelocity = Vector2.zero;
        animator.GetComponent<Animator>();
    }




    void FixedUpdate()
    {
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
        }else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("iswalking", true);
            animator.SetBool("isIdle", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
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


        rb2d.velocity = playerVelocity;


    }



    void Flip()
    {
        Vector2 flipScale = transform.localScale;

        flipScale.x *= -1;

        transform.localScale = flipScale;




    }
        
}
