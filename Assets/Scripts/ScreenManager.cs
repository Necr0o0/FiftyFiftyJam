using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    public Button startButton;

    public CanvasGroup canvasGroup;

    public GameObject hairBrush;
    public GameObject toothBrush;
    public GameObject hair;
    
    //napisy
    public GameObject napis1;
    public GameObject napis2;
    public GameObject napis3;
    public GameObject napis4;
    public GameObject napis5;
    public GameObject napis6;
    
    private bool enableFade;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (enableFade)
        {
            FadeCanvasGroup();
        }
    }

    public void HideMainMenu()
    {
        Debug.Log("Chowanie menu");
        enableFade = true;
        Invoke("StartCutscene", 1);
    }

    public void FadeCanvasGroup()
    {
        canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, 0f, 0.1f);

    }

    private void StartCutscene()
    {
        Debug.Log("Cutscenka wlaczenie");
        hairBrush.SetActive(true);
        toothBrush.SetActive(true);
        hair.SetActive(true);
        Invoke("ShowStory1",1f);
    }

    private void ShowStory1()
    {
        napis1.SetActive(true);
        Invoke("ShowStory2",3f);
    }

    private void ShowStory2()
    {
        napis1.SetActive(false);
        napis2.SetActive(true);
        Invoke("ShowStory3",3f);
    }

    private void ShowStory3()
    {
       napis2.SetActive(false); 
       napis3.SetActive(true);
       Invoke("ShowStory4",3f);
    }

    private void ShowStory4()
    {
       napis3.SetActive(false);
       napis4.SetActive(true);
       Invoke("ShowStory5",3f);
    }

    private void ShowStory5()
    {
        napis4.SetActive(false);
        napis5.SetActive(true);
        napis6.SetActive(true);
        Invoke("NextScene",3f);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
