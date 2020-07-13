using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private int projectileRange = 5;
    [SerializeField] private float projectileForce = 5;
    [SerializeField] private GameObject projectile;
    [SerializeField] private Camera camera;
    private GameObject projectile_instance;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
         
            Vector3 mousePosToWorld = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            Attack(mousePosToWorld);

        }
    }


    void Attack(Vector3 mousePos)
    {
       Vector3 temp = mousePos - transform.position;
       Vector2 dir = new Vector2(temp.x, temp.y).normalized;
       
        projectile_instance = Instantiate(projectile, transform.position, Quaternion.identity);
        projectile_instance.GetComponent<Rigidbody2D>().AddForce(dir * projectileForce, ForceMode2D.Impulse);
     
    }
}
