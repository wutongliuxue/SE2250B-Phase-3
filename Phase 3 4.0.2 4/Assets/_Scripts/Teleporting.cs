using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    public GameObject target;
    public GameObject thePlayer;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
           thePlayer.transform.position= target.transform.position;
            
        }
    }
   
    
}
