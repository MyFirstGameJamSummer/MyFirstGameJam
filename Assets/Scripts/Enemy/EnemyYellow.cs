﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyYellow : Enemy
{
    [SerializeField] public GameObject YellowProjectile;
    public GameObject ShootingPoint;


    float FireRate;
    float NextFire;


    private void Start()
    {
        FireRate = 5f;
        NextFire = Time.time;
    }

    private void Update()
    {
        CheckIfTimeOfFire();
    }

    void CheckIfTimeOfFire()
    {
        if (Time.time > NextFire)
        {
            _animator.SetBool("IsAttacking", true);
            
        }
    }

    protected override void EnemyAnimatorAttacking()
    {

    }
    protected override void EnemyAnimatorDying()
    {
        Debug.Log("Die!");
        _animator.SetTrigger("Death");
    }
    void setAttackFalse()
    {
        _animator.SetBool("IsAttacking", false); 
    }
    void ShootProjectile()
    {
        GameObject go = Instantiate(YellowProjectile, ShootingPoint.transform.position, Quaternion.identity);
        go.GetComponentInChildren<YellowProjectile>().shootedByEnemy = gameObject;
        NextFire = Time.time + FireRate;
    }
    
    
    
    
}




