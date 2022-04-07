using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player2Health : Player1Health
{

    // Update is called once per frame
    
    void Update()
    {
       
        if(curHealth < 1)
        {
            animator.SetBool("Death",true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
             SceneManager.LoadScene(6);

        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            SendDamage(0);
        }

        
    }
    public override void SendDamage(float damageValue)
    {
        curHealth -= 2*damageValue;
        healthBar.value = curHealth;
         //animator.SetFloat("Hit",1);
    }
   
}
