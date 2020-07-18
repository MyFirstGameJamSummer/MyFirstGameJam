using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGreen : MonoBehaviour
{
    [SerializeField] private int damageDeal = 20;
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
           playerHealth.TakeDamages(damageDeal);
        }
    }
}
