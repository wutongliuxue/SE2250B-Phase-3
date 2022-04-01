using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Student Name: Tong Wu
   Student Number: 251155168
   Goal: Switch Scene (From Game Start UI to Game Scene)
*/


public class SwitchScene : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void player1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }

    public void player2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void exitSelectPlayer(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void Back(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Story(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void exitStory(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void Tutorial(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void exitTutorial(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void AboutUs(){
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void exitAboutUs(){
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
}
