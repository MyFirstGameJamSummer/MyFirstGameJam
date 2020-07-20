﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected int maxHealth;
    [SerializeField] public int damageDeal;
    [SerializeField] public int damageProjectile;
    [SerializeField] public int damageMelee;
    [SerializeField] protected Animator _animator;
    public int currentHealth;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        currentHealth = maxHealth;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            EnemyAnimatorDying();
            Debug.Log("Die");
            
        }
    }

    protected abstract  void EnemyAnimatorAttacking();
    protected abstract void EnemyAnimatorDying();

    protected void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            
           Attack(other.gameObject);

        }
       
       
    }

    protected void Attack(GameObject hero)
    {
        PlayerHealth playerHealth = hero.gameObject.GetComponent<PlayerHealth>();
        playerHealth.TakeDamages(damageDeal);
        EnemyAnimatorAttacking();
    }



   
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
    }
    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
