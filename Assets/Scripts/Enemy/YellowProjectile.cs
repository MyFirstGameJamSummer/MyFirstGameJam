using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class YellowProjectile : MonoBehaviour
{
    public AIDestinationSetter AIDes;
    GameObject hero;
    [HideInInspector] public GameObject shootedByEnemy;

    private Vector3 initpos;
    [SerializeField] private float destroyDistance;
    Animator anim;

    private void Awake()
    {
        hero = GameObject.FindGameObjectWithTag("Player");
        AIDes.target = hero.transform;
       
    }

    void Start()
    {
        initpos = transform.position;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(initpos, transform.position) > destroyDistance)
        {
            anim.SetTrigger("Destroy");
            

        }
    }
    private void DestroyProjectile()
    {
        Destroy(gameObject,0.3f );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name.Equals("Outbound"))
        {
           DestroyProjectile();
        }
        else if (other.gameObject.tag == "Player")
        {
           
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            playerHealth.TakeDamages(shootedByEnemy.GetComponent<EnemyYellow>().damageDeal);
            gameObject.GetComponentInParent<AIPath>().canMove = false;
            DestroyProjectile();
        }
    }
}
