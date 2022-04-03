using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorClose : MonoBehaviour
{
     public GameObject ui;
     public GameObject doorCloser;
    // Start is called before the first frame update
    void Start()
    {
       ui.SetActive(false);
        
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
         ui.SetActive(true);
         if((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
         {
            //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
            doorCloser.gameObject.SetActive(true);
         }
    }
    void OnTriggerExit()
    {
        ui.SetActive(false);
    }

}
