using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class YellowProjectile : MonoBehaviour
{
    public AIDestinationSetter AIDes;
     GameObject hero;


    private void Awake()
    {
        hero = GameObject.FindGameObjectWithTag("Player");
        AIDes.target = hero.transform;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
