using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHairBrushController : MonoBehaviour
{
   public ToothBrushPackController[] keyboardsInputs;
   public float lerpSpeed = 0.1f;

   private void Update()
   {
      if (Input.GetKey(KeyCode.Q) && keyboardsInputs[0] != null)
      {
         transform.position = Vector3.Lerp(transform.position, keyboardsInputs[0].transform.position, lerpSpeed);
       
      }
      Debug.Log(keyboardsInputs[0].untangled +  keyboardsInputs[1].untangled);
         if (keyboardsInputs[0].untangled < keyboardsInputs[1].untangled)
         {
            if (Input.GetKey(KeyCode.A) && keyboardsInputs[1] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[1].transform.position, lerpSpeed); }
         }
            if (keyboardsInputs[0].untangled < keyboardsInputs[1].untangled && keyboardsInputs[1].untangled < keyboardsInputs[2].untangled)
            {
               if (Input.GetKey(KeyCode.Z)&& keyboardsInputs[2] != null) { transform.position = Vector3.Lerp(transform.position, keyboardsInputs[2].transform.position, lerpSpeed); }
            }
     
      
      
      
    
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
      Debug.Log("Wchodzi lewa");

      var tangledpoint = other.GetComponent<ToothBrushPackController>();
      tangledpoint.untangled--;
      
      if (tangledpoint.untangled <= 0)
      {
         Destroy(other.gameObject);
      }
   }

   private void middlelevel1()
   {
      
   }
}
