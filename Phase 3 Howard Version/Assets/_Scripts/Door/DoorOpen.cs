using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
     public GameObject ui;
     public GameObject doorOpener;
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
            doorOpener.gameObject.SetActive(false);
         }
    }
    void OnTriggerExit()
    {
        ui.SetActive(false);
    }

}
