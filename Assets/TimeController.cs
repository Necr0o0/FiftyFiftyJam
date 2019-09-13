using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public float timeLeft= 10.0f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<RectTransform>().sizeDelta -= new Vector2(0,1f);
        
        if (this.GetComponent<RectTransform>().sizeDelta.y < 0.0f)
        {
            Debug.Log("Game Over");
        }
    }
}
