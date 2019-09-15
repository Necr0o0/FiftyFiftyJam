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

   private Vector3 destinationPoint;
   
   private KeyCode[] lol =
   {
      KeyCode.Q, KeyCode.A, KeyCode.Z,
      KeyCode.W, KeyCode.S, KeyCode.X,
      KeyCode.E, KeyCode.D, KeyCode.C,
      KeyCode.R, KeyCode.F, KeyCode.V,
      KeyCode.T, KeyCode.G, KeyCode.B
   };
   

   private int int_score = 0;
   private void Start()
   {
      score.text = "0";
      destinationPoint = transform.position;
   }

   private void Update()
   {
      

      for (int i = 0; i < 15; i++)
      {
         if (Input.GetKey(lol[i]))
         {
            destinationPoint = keyboardsInputs[i].transform.position;
           // transform.position = Vector3.Lerp(transform.position, keyboardsInputs[i].transform.position, lerpSpeed); 
         }
      }

      transform.position = Vector3.Lerp(transform.position, destinationPoint, lerpSpeed);

   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      int_score+=3;
      score.text = int_score.ToString();
     // Debug.LogWarning("Left score "+ int_score);
     
     
      Debug.Log("Wchodzi lewa");

     
   
     
      var tangledpoint = other.GetComponent<ToothBrushPackController>();
      tangledpoint.untangled--;

      if(!tangledpoint.parentSpriteRenderer.gameObject.GetComponent<AudioSource>().isPlaying)
      {
         tangledpoint.parentSpriteRenderer.gameObject.GetComponent<AudioSource>().Play();
      }
      
      Debug.Log(tangledpoint.untangled);

      if (tangledpoint.parentSpriteRenderer.sprite != tangledpoint.level3)
      {
         switch (tangledpoint.untangled)
         {
            case (0):
               tangledpoint.parentSpriteRenderer.sprite = tangledpoint.level1;
               break;
            case (-2):
               tangledpoint.parentSpriteRenderer.sprite = tangledpoint.level2;
               break;
            case (-4):
               tangledpoint.parentSpriteRenderer.sprite = tangledpoint.level3;
               break;
         }
         this.GetComponent<ParticleSystem>().Play();
      }
     
      
     /* if (tangledpoint.untangled < -9)
      {
         Debug.LogWarning("powinno sie zmienic");
         Debug.Log(  other.GetComponentInParent<SpriteRenderer>());
         tangledpoint.parentSpriteRenderer.sprite = tangledpoint.level1;
         
      }
     */

   }

}
