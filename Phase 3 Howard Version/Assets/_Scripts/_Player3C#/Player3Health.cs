using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player3Health : MonoBehaviour
{
    public float curHealth;
    public float maxHealth;
    public Slider healthBar;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        healthBar.value = curHealth;
        healthBar.maxValue = maxHealth;
        animator = GetComponent<Animator>();

    }

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
    void OnCollisionEnter(Collision collision){

        if(collision.gameObject.tag == "Giant")
        {
           SendDamage(15);
           
        }

        if(collision.gameObject.tag == "Monster")
        {
           SendDamage(20);
           
        }
    }
    public void SendDamage(float damageValue)
    {
        curHealth -= damageValue;
        healthBar.value = curHealth;
         //animator.SetFloat("Hit",1);
    }

}
