using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class YellowProjectile : MonoBehaviour
{
    public AIDestinationSetter AIDes;
     GameObject hero;

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
}
