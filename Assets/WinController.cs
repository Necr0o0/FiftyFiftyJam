using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinController : MonoBehaviour
{
    public GameObject PlayerLeft;
    public GameObject PlayerRight;
    
    public TextMeshProUGUI leftWinText;
    public TextMeshProUGUI rightWinText;
    
    public SpriteRenderer[] levelLeftCheck;
    public SpriteRenderer[] levelRightCheck;

    public Sprite lastLeftLevel;
    public Sprite LastRightLevel;

    private bool leftWin = false;
    private bool rightWin = false;
    
    private void Update()
    {
        leftWin = true;
        foreach (var x in levelLeftCheck)
        {
            if (x.sprite == lastLeftLevel) leftWin = true;
            else
            {
                leftWin = false;
                break;
            }
            
        }
        
                rightWin = true;
        
        foreach (var x in levelRightCheck)
        {
            if (x.sprite != LastRightLevel)
            {
                rightWin = false;
                break;
            }
//            if (x.sprite == LastRightLevel) rightWin = true;
//            else
//            {
//            }
        }

        if (leftWin)
        {
            leftWinText.gameObject.SetActive(true);
            PlayerLeft.SetActive(false);
        }
        if (rightWin)
        {
            rightWinText.gameObject.SetActive(true);
            PlayerRight.SetActive(false);
        }
        
        if (leftWin && rightWin)
        {
            Invoke("Endgame",2f);
           
        }
    }

    void Endgame()
    {
        SceneManager.LoadScene(2);
    }
}
