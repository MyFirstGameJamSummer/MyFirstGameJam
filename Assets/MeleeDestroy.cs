using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MeleeDestroy : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            gameObject.SetActive(false);
            animator.SetBool("IsAttacking", false);
        }
        
    }
}
