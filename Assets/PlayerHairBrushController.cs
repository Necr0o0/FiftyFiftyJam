using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHairBrushController : MonoBehaviour
{
   public TextMeshProUGUI score;
   public ToothBrushPackController[] keyboardsInputs;
   public float lerpSpeed = 0.15f;

   private int int_score = 0;
   private void Start()
   {
      score.text = "0";
   }

   private void Update()
   {


      Debug.Log(keyboardsInputs[0].untangled);
      Debug.Log(keyboardsInputs[1].untangled);
      
      if (Input.GetKey(KeyCode.Q) && keyboardsInputs[0] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[0].transform.position, lerpSpeed); }
      if (Input.GetKey(KeyCode.A) && keyboardsInputs[1] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[1].transform.position, lerpSpeed); }
      if (Input.GetKey(KeyCode.Z)&& keyboardsInputs[2] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[2].transform.position, lerpSpeed); }
      
      if (Input.GetKey(KeyCode.E)&& keyboardsInputs[3] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[3].transform.position, lerpSpeed); }
      if (Input.GetKey(KeyCode.D)&& keyboardsInputs[4] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[4].transform.position, lerpSpeed); }
      if (Input.GetKey(KeyCode.C)&& keyboardsInputs[5] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[5].transform.position, lerpSpeed); }
      
      /*
      if (Input.GetButtonDown("a"))
      {
         Mathf.Lerp(transform.position.x, keyboardsInputs[1].transform.position.x, 0.1f);
      }
      if (Input.GetButtonDown("z"))
      {
         Mathf.Lerp(transform.position.x, keyboardsInputs[2].transform.position.x, 0.1f);
      }
      */
      /*
      if (Input.GetButtonDown("w"))
      {
         Mathf.Lerp(transform.position.x, keyboardsInputs[0].transform.position.x, 0.1f);
      }
      if (Input.GetButtonDown("s"))
      {
         Mathf.Lerp(transform.position.x, keyboardsInputs[0].transform.position.x, 0.1f);
      }
      if (Input.GetButtonDown("x"))
      {
         Mathf.Lerp(transform.position.x, keyboardsInputs[0].transform.position.x, 0.1f);
      }*/
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      int_score+=3;
      score.text = int_score.ToString();
      Debug.LogWarning("Left score "+ int_score);
      Debug.Log("Wchodzi lewa");

      var tangledpoint = other.GetComponent<ToothBrushPackController>();
      
   }

}
