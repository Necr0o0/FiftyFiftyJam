using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToothbrushMovement : MonoBehaviour
{
    private int int_score = 0;
    public TextMeshProUGUI score;
    private void Start()
    {
        Cursor.visible = false;
        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

        var v3 = Input.mousePosition;

        v3.z = -2f;
        v3.x = Camera.main.ScreenToWorldPoint(v3).x;
        v3.y = Camera.main.ScreenToWorldPoint(v3).y;

        
        transform.position = Vector3.Lerp(transform.position,v3,0.5f);

        if (transform.position.x < 0.1)
        {
            Vector3 tmp = new Vector3(0.1f, transform.position.y, transform.position.z);
            transform.position = tmp;
        }

        if (transform.position.x > 1.7f)
        {
            Vector3 tmp = new Vector3(1.7f, transform.position.y, transform.position.z);
            transform.position = tmp;
        }

        if (transform.position.y < 0)
        {
            Vector3 tmp = new Vector3(transform.position.x, 0, transform.position.z);
            transform.position = tmp;
        }

        if (transform.position.y > 2f)
        {
            Vector3 tmp = new Vector3(transform.position.x, 2f, transform.position.z);
            transform.position = tmp;
        }
        //Debug.Log(v3);


    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("dziala");
        int_score++;

        var dirtcounter = other.GetComponent<ScoreRightController>();
        score.text = int_score.ToString();
        Debug.LogWarning("Right score "+ int_score);
        this.GetComponent<ParticleSystem>().Play();

        if (!dirtcounter.GetComponent<AudioSource>().isPlaying)
        {
            dirtcounter.GetComponent<AudioSource>().Play();
        }
       

        dirtcounter.collisionCounter--;
        switch (dirtcounter.collisionCounter)
        {
            case (0):
                dirtcounter.parent.sprite = dirtcounter.tooth1;
                break;
            case (-2):
                dirtcounter.parent.sprite = dirtcounter.tooth2;
                break;
            case (-4):
                dirtcounter.parent.sprite = dirtcounter.tooth3;
                dirtcounter.GetComponent<ParticleSystem>().Play();
                break;
         
        }
        
    }
}
