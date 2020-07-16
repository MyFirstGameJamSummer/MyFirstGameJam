using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private int projectileRange = 5;
    [SerializeField] private float projectileForce = 5;
    [SerializeField] private GameObject projectile;
    [SerializeField] private Camera camera;
    private GameObject projectile_instance;
    public GameObject meleeAttack;
    public GameObject MeleeAttackpoint;
    public GameObject RangeAttackPoint;
    public  Animator animator;

    private bool isMeleeAttacking = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMeleeAttacking)
        {
         
            Vector3 mousePosToWorld = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            Attack(mousePosToWorld);
            animator.SetBool("IsAttacking", true);

        } 
        
        else if (Input.GetMouseButtonUp(0) && !isMeleeAttacking)
        {
            animator.SetBool("IsAttacking", false);
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            isMeleeAttacking = true;
            meleeAttack.SetActive(true);
            animator.SetBool("IsAttacking", true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            isMeleeAttacking = false;
            meleeAttack.SetActive(false);
            animator.SetBool("IsAttacking", false);
        }

    }


   public void Attack(Vector3 mousePos)
    {
       Vector3 temp = mousePos - transform.position;
       Vector2 dir = new Vector2(temp.x, temp.y).normalized;
       
        projectile_instance = Instantiate(projectile, RangeAttackPoint.transform.position, Quaternion.identity);

        projectile_instance.GetComponent<Rigidbody2D>().AddForce(dir * projectileForce, ForceMode2D.Impulse);
     
    }


   private void OnCollisionEnter2D(Collision2D other)
   {
       
   }
}
