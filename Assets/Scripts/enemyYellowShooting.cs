using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyYellowShooting : MonoBehaviour
{
    [SerializeField] public GameObject YellowProjectile;
    public GameObject ShootingPoint;
    public Animator YellowAnim;

    private float Distance;
    float FireRate;
    float NextFire;
    public GameObject Hero;
    void Awake()
    {
      FireRate = 5f;
      NextFire = Time.time;
     }

     private void Update()
      {
         
        Distance = Mathf.Abs(Hero.transform.position.x - transform.position.x);
                if (Distance <= 5f)
        {
            CheckIfTimeOfFire();
        }

      }

     void CheckIfTimeOfFire()
    {
     if (Time.time > NextFire)
    {
      YellowAnim.SetBool("IsAttacking", true);
       

    }
    }

    void setAttackFalse()
      {
         YellowAnim.SetBool("IsAttacking", false); 
    }
    void ShootProjectile()
    {
        GameObject go = Instantiate(YellowProjectile, ShootingPoint.transform.position, Quaternion.identity);
        go.GetComponentInChildren<YellowProjectile>().shootedByEnemy = gameObject;
        NextFire = Time.time + FireRate;
    }
}
