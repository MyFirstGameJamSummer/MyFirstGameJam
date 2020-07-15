using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_destroy : MonoBehaviour
{
  
    
   public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.K))
        {
            anim.SetTrigger("Destroy");
            Destroy(gameObject, 1.5f);

        }
        
    }
}
