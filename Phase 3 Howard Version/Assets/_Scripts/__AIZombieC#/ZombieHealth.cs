using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZombieHealth : MonoBehaviour
{
    public float curHealth;
    public float maxHealth;
    
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
       
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
       
        if(curHealth < 1)
        {
            animator.SetBool("Death",true);
        
    }
    void OnCollisionEnter(Collision collision){

        if((collision.gameObject.tag == "Player") )
        {
           curHealth -= 50;

           
        }

        
    }
   
}
}