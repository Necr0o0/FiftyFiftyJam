using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void StartCutscene()
    {
        Debug.Log("Cutscenka wlaczenie");
        hairBrush.SetActive(true);
        toothBrush.SetActive(true);
        hair.SetActive(true);
        //napis1.SetActive(true);
        //napis2.SetActive(true);
    }
}
