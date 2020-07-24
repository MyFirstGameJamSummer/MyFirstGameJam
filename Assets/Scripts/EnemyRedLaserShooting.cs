using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRedLaserShooting : MonoBehaviour
{
    public Animator animRed;
    public GameObject BigLaser;
    public GameObject SmallLaser;
   

   public void SetBigLaserActive()
    {
        
        BigLaser.SetActive(true);
        SmallLaser.SetActive(false);
    }
    public void SetSmallLaserActive()
    {
        SmallLaser.SetActive(true);
        BigLaser.SetActive(false);
    }
    public void FinishAttack()
    {
        SmallLaser.SetActive(false);
        BigLaser.SetActive(false);
    }
    public void animReset()
    {
        animRed.SetBool("IsAttacking", false);
        animRed.SetBool("IsIdle", true);
    }
    public void CharDeath()
    {
        animRed.SetTrigger("Death");
    }
    
    
}
