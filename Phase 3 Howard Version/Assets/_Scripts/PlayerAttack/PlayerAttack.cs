using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator animator;
    // Update is called once per frame
    void Start()
    {
    
        animator= GetComponent<Animator>();  
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
             Attack();
        }
    }
    private void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
