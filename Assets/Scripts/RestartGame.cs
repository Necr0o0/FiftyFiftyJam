using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private int sceneCounter = 0;


    public GameObject player1;
    public GameObject player2;
  
    
    public GameObject subtitle1; // dziekuje za pomoc
    public GameObject subtitle2; // nie
    public GameObject subtitle3; //  to ja dziekuje ( ta sama szczotka)
    public GameObject subtitle4; // kiss scene
    public GameObject fin;

    private void Start()
    {
        
        Invoke("SubtitleScene"+sceneCounter,1f);
    }

    private void SubtitleScene0()
    {
      
        sceneCounter++;
        player1.SetActive(true);
        player2.SetActive(true);
        Invoke("SubtitleScene"+sceneCounter,2f);
    }
    
    private void SubtitleScene1()
    {
        sceneCounter++;
        subtitle1.SetActive(true);
        Invoke("SubtitleScene"+sceneCounter,2f);

    }

    private void SubtitleScene2()
    {
        sceneCounter++;
        subtitle1.SetActive(false);
        subtitle2.SetActive(true);
        Invoke("SubtitleScene"+sceneCounter,2f);
    }
    private void SubtitleScene3()
    {
        sceneCounter++;
        subtitle2.SetActive(false);
        subtitle3.SetActive(true);
        Invoke("SubtitleScene"+sceneCounter,2f);
    }
    
    private void SubtitleScene4()
    {
        sceneCounter++;
        subtitle3.SetActive(false);
        player1.SetActive(false);
        player2.SetActive(false);
        subtitle4.SetActive(true);
        Invoke("Fin",2f);
    }

    private void Fin()
    {
        //subtitle4.SetActive(false);
        Cursor.visible = true;
        fin.SetActive(true);
    }


    public void GameRestart()
    {
        SceneManager.LoadScene(1);
    }
    
    
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
