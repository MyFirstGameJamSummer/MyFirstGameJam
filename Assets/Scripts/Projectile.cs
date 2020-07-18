using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     Animator anim;
    [SerializeField] private float destroyDistance;
    private Vector3 initPos;
    

    void Start()
    {
        initPos = transform.position;
       
        
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        
        if (Vector3.Distance(initPos, transform.position) > destroyDistance)
        {
            anim.SetTrigger("Destroy");
            Destroy(gameObject, 1.5f);

        }
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name.Equals("Outbound"))
        {
            ProjectileDestroy();
        }
        else if (other.gameObject.tag == "Enemy")
        {
            
            Enemy enemy = other.GetComponent<Enemy>();
            enemy.TakeDamage(enemy.damageProjectile);
            Debug.Log(enemy.currentHealth);
            ProjectileDestroy();
        }
    }


    void ProjectileDestroy()
    {
        anim.SetTrigger("Destroy");
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Destroy(GetComponent<Collider2D>());
        Destroy(gameObject, 0.5f);
      
    }
    public void DestroyProjectile()
    {
        Destroy(gameObject, 0.3f);

    }
}
