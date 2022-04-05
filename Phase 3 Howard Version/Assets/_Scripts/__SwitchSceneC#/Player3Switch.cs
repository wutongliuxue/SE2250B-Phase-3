using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player3Switch : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(13);
    }
}
