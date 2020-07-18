using System;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemyGreenPathFinder : MonoBehaviour
{
    private int damageDeal;

    private CircleCollider2D areaCollider;

    private AIPath _aiPath;
    
    // Start is called before the first frame update
    void Start()
    {
        areaCollider = GetComponent<CircleCollider2D>();
        _aiPath = GetComponent<AIPath>();

        _aiPath.canSearch = false;
        _aiPath.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _aiPath.canMove = true;
            _aiPath.canSearch = true;
        }
    }
}
