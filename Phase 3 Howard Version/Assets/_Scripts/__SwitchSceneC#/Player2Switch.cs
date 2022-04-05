using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Switch : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(12);
    }
}

