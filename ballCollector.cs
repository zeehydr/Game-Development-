using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballCollector : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;


    public void OnTriggerEnter(Collider col){
        if(col.gameObject.name== "redBall"){
            Destroy(col.gameObject);
            lives = lives-1;
            Debug.Log("I Collide red ball and my remaining lives are: "+lives);
        }

        if(col.gameObject.name== "greenBall"){
            Destroy(col.gameObject);
            score = score+10;
            Debug.Log("I Collide green ball and my score is: "+score);
        }
        if(col.gameObject.name== "blueBall"){
            Destroy(col.gameObject);
            score = score+5;
            Debug.Log("I Collide with blue ball and my score is: "+score);
        }
       if(lives == 0){
        Application.Quit();
       }

        if(col.gameObject.name == "targetBall"){
            SceneManager.LoadScene("level1");
        }

    }

}
