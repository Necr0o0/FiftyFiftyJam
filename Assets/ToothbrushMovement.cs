using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToothbrushMovement : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        var v3 = Input.mousePosition;
        v3.z = 10.0f;
        v3 = Camera.main.ScreenToWorldPoint(v3);
        
        transform.position = v3;

    }
}
