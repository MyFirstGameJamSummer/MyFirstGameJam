using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyYellow : Enemy    
{
    
    

    
     // 

    protected override void EnemyAnimatorAttacking()
    {

    }
    protected override void EnemyAnimatorDying()
    {
       
        
        _animator.SetTrigger("Death");
    }

    }

    
    
    
    





