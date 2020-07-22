using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!_animator.GetBool("IsAttacking"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(1,0), 10, LayerMask.GetMask("Characters"));

            if (hit.collider != null && hit.collider.gameObject.tag == "Player") 
            {
                EnemyAnimatorAttacking();
            }
        }

    }

    protected override void EnemyAnimatorAttacking()
    {
        _animator.SetBool("IsAttacking", true);
        _animator.SetBool("IsIdle", false);
    }

    protected override void EnemyAnimatorDying()
    {
        _animator.SetTrigger("Death");
    }
}
