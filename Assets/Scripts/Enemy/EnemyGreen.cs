using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGreen : Enemy
{
    [SerializeField] AIPath aipath;
    
    protected override void EnemyAnimatorAttacking()
    {
       _animator.SetBool("IsAttacking", true);


        



    }

    protected override void EnemyAnimatorDying()
    {
        _animator.SetTrigger("Death");
        aipath.canMove = false;
    }
    public void AttackFinish()
    {
        _animator.SetBool("IsAttacking", false);
       

    }
    
}
