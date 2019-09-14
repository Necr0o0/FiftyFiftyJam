using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeController : MonoBehaviour
{
    public RawImage endSplashScreen;
    public float timeLeft= 10.0f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<RectTransform>().sizeDelta -= new Vector2(0,1f);
        
        if (this.GetComponent<RectTransform>().sizeDelta.y < 0.0f)
        {
            Debug.Log("Game Over");
           // endSplashScreen.enabled = true;
          //  endSplashScreen.transform.localScale += new Vector3(0.5f,0.5f,0.5f);
            if (endSplashScreen.transform.localScale.x > 50)
            {
                Debug.Log("NO END NOW");
               // SceneManager.LoadScene(2);
            } 
        }
    }
}
